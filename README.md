# Input System básico
Ejemplo donde se mueve una esfera en la pantalla (sin salir de la misma), y disparando una pequeña bala. Todo usando el paquete Input System, con soporte de teclado y Joystick. 

Se mueve con el stick izquierdo y el D-Pad del Joystick, así como las teclas de dirección y WASD del teclado. 

La forma de usar el Input System es con envío de eventos (Send Event), lo que hace que no haya que inicializar ni definir que hacer con el input, sino que se definen métodos para responder a los eventos recibidos (Por ejemplo, la acción de input "Moverse" envía un evento con ese nombre, y para programarlo definimos un método llamado "OnMoverse".

