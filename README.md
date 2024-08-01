# Sistema de Gestión de Equipos de Fútbol

## Descripción del Proyecto

Este sistema de gestión está diseñado para ayudar a un club deportivo a administrar la conformación de los equipos de fútbol que participan en un torneo interno. Permite registrar jugadores y entrenadores, gestionar equipos, y mantener un control sobre las inscripciones y los roles de cada participante.

## Funcionalidades

El sistema ofrece un menú interactivo que permite realizar las siguientes acciones:

1. **Registrar un jugador**: Añadir un jugador al torneo, especificando su DNI, apellidos, nombres, fecha de nacimiento y posición de juego, evitando duplicaciones.
2. **Registrar un entrenador**: Añadir un entrenador con su DNI, apellidos, nombres y número de teléfono de contacto, evitando duplicaciones.
3. **Registrar un equipo**: Crear un equipo con un código identificador, nombre, colores y asignar un entrenador previamente registrado, evitando duplicaciones.
4. **Asociar un jugador a un equipo**: Integrar un jugador previamente registrado a un equipo.
5. **Listar equipos**: Mostrar todos los equipos con sus datos completos y los de su entrenador.
6. **Listar jugadores por equipo**: Dado un código de equipo, listar los datos completos de los jugadores asignados, ordenados por apellido.
7. **Expulsar a un jugador**: Remover a un jugador del torneo, incluyendo su eliminación del equipo asociado.
8. **Listar participantes del torneo**: Mostrar todos los participantes (jugadores y entrenadores) ordenados por apellido, indicando sus datos completos y los equipos a los que están asociados.

## Requisitos

- C#
- Biblioteca `datetime` para manejar fechas
- Biblioteca `collections` para gestionar estructuras de datos

## Instalación

1. Clona el repositorio:
   ```bash
   https://github.com/WayneJOLY/TP-Programacion-3-Torneo-de-Futbol.git
