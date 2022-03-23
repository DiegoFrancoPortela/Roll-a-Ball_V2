# Roll-a-Ball_V2
Versión propia del Tutorial de Unity, **Roll a Ball**.

## Más muros.
Para darle una estética diferente y algo variada he añadido muros en forma de laberinto.
![](https://i.ibb.co/1sLssJ2/Muros-Laberinto.png)

## Menos puntos.
He añadido que al tocar los muros pierdas un punto, dando algo más de dificultad al juego.
![](https://i.ibb.co/S6G9QCN/Trigger-Walls.png)

Para hacer esto, decidí crear un nuevo Tag, **"TriggerWalls"**, y con él, objetos iguales a los muros, aun que algo más grandes
y asignarlos a un **"Material"** que sea transparente.
Estos **"TriggerWalls"** actuarán como Hitbox de los muros, debido a que, si activo **"Is Trigger"** en los muros originales, 
estos perderían las físicas.
