# SkillUp Workshops
Relevamiento

El siguiente extracto se obtuvo de una entrevista realizada con el cliente:
Nosotros somos SkillUp, una startup que conecta a gente que quiere aprender oficios con talleres presenciales.
Queremos armar un sistema sencillo, pero bien pensado, para manejar toda la información que usamos día a día.
Necesitamos registrar Talleres, que serían los cursos presenciales que ofrecemos. De cada taller queremos guardar el nombre, una breve descripción, el costo, la duración en semanas, la cantidad máxima de alumnos permitidos y el nivel de dificultad (inicial, intermedio, avanzado).
Cada taller está a cargo de un Instructor. Necesitamos que de cada instructor tengamos nombre completo, documento, teléfono, especialidad (ej: carpintería, cerámica, mecánica), y si está habilitado o no para dictar talleres actualmente.
 Un mismo instructor puede dictar varios talleres a la vez, si tiene disponibilidad.
También registramos los Alumnos que se inscriben. De cada alumno queremos el nombre completo, fecha de nacimiento, correo electrónico, teléfono, dirección, y un número de contacto de emergencia.
Cuando un alumno se inscribe a un taller, se genera una Inscripción. Esa inscripción debe registrar el alumno, el taller, la fecha en que se inscribió, si ya pagó o no, y su estado actual (activa, cancelada, finalizada).
Ah, también queremos que cada taller tenga asignado un Espacio Físico donde se dicta. De cada espacio necesitamos saber: nombre del lugar, dirección completa, capacidad máxima, y si cuenta con accesibilidad para personas con movilidad reducida.

Como política de la empresa:
No queremos que si un alumno cancela su inscripción se elimine su registro de alumno.
Si un taller se elimina, las inscripciones asociadas también deberían desaparecer automáticamente.


Queremos que todos los datos que se ingresen sean validados. Ejemplos:
Que los mails estén bien formados.
Que los teléfonos sean numéricos y de largo razonable.
Que no se pueda inscribir a alguien en un taller que ya está lleno.
Que las fechas de inscripción tengan sentido.
Y por favor, que todo eso esté concentrado en una sola parte del sistema. Si hay algún error en los datos, queremos que el sistema lo indique bien clarito para poder corregirlo rápido.

Restricciones Técnicas

El sistema debe ser desarrollado como un proyecto de consola en C#.
Las entidades deben aplicar encapsulamiento, utilizando atributos privados con accesos controlados mediante métodos públicos.
Se deben reflejar las relaciones de composición y agregación de manera adecuada:
Los talleres deben tener compuestos sus espacios físicos y sus inscripciones.
Los alumnos deben agregarse a las inscripciones, sin eliminarse si la inscripción se cancela.
Debe crearse una clase estática responsable de todas las validaciones de datos del sistema.
Las validaciones deben lanzar excepciones personalizadas que detallen claramente el problema detectado.
Cada clase debe desarrollarse en un archivo independiente.
Se debe realizar la validación lógica e integridad de datos durante la creación y modificación de objetos (por ejemplo, no permitir talleres sin espacio físico asignado o inscripciones a talleres completos).
Se deben utilizar tipos de datos apropiados (string, int, DateTime, bool, enum, List<>, etc.) en todos los atributos y métodos.
El proyecto debe estar subido a un repositorio de Github

