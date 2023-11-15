Challenge24
2.1. Rigidbody hinzufügen
2.2. nach unten, oben ist in Y Richtung
2.3. Rigidbody -> Mass
3. entweder "Is Kinematic" oder über Constraints
4. Drag auf Maximum
5. Mass auf Minimun
6.1. bleibt liegen
6.2. physicMaterial
6.4. Constraints setzen
7. hat Masse, bewegt sich aber nicht -> für temporäre Sachen geeignet

Challenge25
3.1. OnCollisionEnter Methode
3.2. OnCollisionExit Methode
3.3. Übergabeparameter other
4.1. OnTriggerEnter Methode
4.2. Collision -> physikalische Kollision, Trigger -> Kollision ohne Physik

Challenge26
2.2. Sphere
2.3. Komponente: Rigidbody, _rigidbody.AddForce(force * launchDirection, ForceMode.Impulse);
2.4. Skript darauf anwenden? Vector3.right oder left
2.6. Ändern von ForceMode
2.7. Ändern von Drag
3.1. _rigidbody.AddForce(direction, ForceMode.Impulse);
3.2. AddForce
3.3. OnTriggerEnter
3.4. nach unten (-Y)
3.6. es wird schwerer, den Ball abzubremsen

Challenge28
1.1. In Assets packen
1.2. AIFF, WAV, MP3, and Ogg
2.1. 1) in Assets auf Sound und dann im Inspektor unten rechts abspielen
3.1. Inspektor -> Volumne oder Toggle Audio On Off in Scene View oben rechts
3.2. Audio Listener in Main Camera
3.3. Spatial Blend einstellen auf 1 + Volumne Rolloff rumspielen

Challenge29
1.1. Licht geht aus/an
2.1. directional
2.2. Position und Rotation ändern
2.3. Schattenwurf und Ausleuchtung
3.1. Type vom Licht im Inspektor ändern
3.2. Range
3.3. Color
3.4. No Shadows
4.1. Spot Angle
5.1. Skybox
5.2. Window -> Rendering -> Lightning -> Environment