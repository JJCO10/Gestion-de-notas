-- Crear Roles
CREATE TABLE Roles (
    IDRol NVARCHAR(10) PRIMARY KEY,
    Rol NVARCHAR(20) NOT NULL
);

-- Crear Permisos
CREATE TABLE Permisos (
    IDPermiso NVARCHAR(10) PRIMARY KEY,
    Permiso NVARCHAR(20) NOT NULL,
    IDRol NVARCHAR(10),
    FOREIGN KEY (IDRol) REFERENCES Roles(IDRol)
);

-- Crear Usuarios
CREATE TABLE Usuarios (
    IDUsuario NVARCHAR(10) PRIMARY KEY,
    Usuario NVARCHAR(20) NOT NULL,
    Contraseña NVARCHAR(20) NOT NULL,
    IDRol NVARCHAR(10),
    FOREIGN KEY (IDRol) REFERENCES Roles(IDRol)
);

-- Crear Especialidades
CREATE TABLE Especialidades (
    IDEspecialidad NVARCHAR(10) PRIMARY KEY,
    Especialidad NVARCHAR(20) NOT NULL
);

-- Crear Grados
CREATE TABLE Grados (
    IDGrado NVARCHAR(10) PRIMARY KEY,
    Grado NVARCHAR(15) NOT NULL
);

-- Crear Docentes
CREATE TABLE Docentes (
    IDDocente NVARCHAR(12) PRIMARY KEY,
    NombreCompleto NVARCHAR(40) NOT NULL,
    FechaNacimiento DATE,
    Direccion NVARCHAR(30),
    Especialidad NVARCHAR(10),
    Telefono NVARCHAR(10),
    Correo NVARCHAR(30),
    IDUsuario NVARCHAR(10),
    FOREIGN KEY (Especialidad) REFERENCES Especialidades(IDEspecialidad),
    FOREIGN KEY (IDUsuario) REFERENCES Usuarios(IDUsuario)
);

-- Crear Cursos
CREATE TABLE Cursos (
    IDCurso NVARCHAR(10) PRIMARY KEY,
    Curso NVARCHAR(10) NOT NULL,
    Año DATE,
    IDGrado NVARCHAR(10),
    FOREIGN KEY (IDGrado) REFERENCES Grados(IDGrado)
);

-- Crear Estudiantes
CREATE TABLE Estudiantes (
    IDEstudiante NVARCHAR(12) PRIMARY KEY,
    NombreCompleto NVARCHAR(40) NOT NULL,
    FechaNacimiento DATE,
    Direccion NVARCHAR(30),
    Telefono NVARCHAR(10),
    Correo NVARCHAR(30),
    IDCurso NVARCHAR(10),
    IDUsuario NVARCHAR(10),
    FOREIGN KEY (IDCurso) REFERENCES Cursos(IDCurso),
    FOREIGN KEY (IDUsuario) REFERENCES Usuarios(IDUsuario)
);

-- Crear EspecialidadDocente
CREATE TABLE EspecialidadDocente (
    IDEspecialidad NVARCHAR(10),
    IDDocente NVARCHAR(12),
    PRIMARY KEY (IDEspecialidad, IDDocente),
    FOREIGN KEY (IDEspecialidad) REFERENCES Especialidades(IDEspecialidad),
    FOREIGN KEY (IDDocente) REFERENCES Docentes(IDDocente)
);

-- Crear Periodos
CREATE TABLE Periodos (
    IDPeriodo NVARCHAR(10) PRIMARY KEY,
    Periodo NVARCHAR(2) NOT NULL,
    FechaInicio DATE,
    FechaFinalizacion DATE
);

-- Crear Materias
CREATE TABLE Materias (
    IDMateria NVARCHAR(15) PRIMARY KEY,
    Materia NVARCHAR(20) NOT NULL,
    IDDocente NVARCHAR(12),
    IDGrado NVARCHAR(10),
    FOREIGN KEY (IDDocente) REFERENCES Docentes(IDDocente),
    FOREIGN KEY (IDGrado) REFERENCES Grados(IDGrado)
);

-- Crear Notas
CREATE TABLE Notas (
    IDNota NVARCHAR(10) PRIMARY KEY,
    NotaEstudiante DECIMAL(5, 2),
    Observacion NVARCHAR(100),
    IDEstudiante NVARCHAR(12),
    IDMateria NVARCHAR(15),
    IDPeriodo NVARCHAR(10),
    FOREIGN KEY (IDEstudiante) REFERENCES Estudiantes(IDEstudiante),
    FOREIGN KEY (IDMateria) REFERENCES Materias(IDMateria),
    FOREIGN KEY (IDPeriodo) REFERENCES Periodos(IDPeriodo)
);