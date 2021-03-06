﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MouseWheel += new MouseEventHandler(panelFondo_Wheel);
        }

        //Variables para inicio de sesion
        public string Usuario = "Invitado";
        public string Nombre;
        public string contraseña = "1234";
        public string Saludo;
        //Variable para desactivar el loginbar
        public bool login = false;
        //Variables animacion panel categorias
        public int anchopanel = 60;
        //Variables animacion panel galeria
        int animacionscroll = 6;
        int timermousewheelint = 0;
        //Variables Importantes
        //En serio muy importantes
        //Variables de cambio de informacion
        int scroll = 0;
        int categoria = 0;
        public int Categoria = 0;
        public int Scroll = 0;
        double precio1 = 0.0;
        double precio2 = 0.0;
        double precio3 = 0.0;
        double precio4 = 0.0;
        double precio5 = 0.0;
        double precio6 = 0.0;

        int animacioncategoria = 23;


        public void ResetearControlesCompra()
        { 
            
            
                Cantidad1.Maximum = 12;
                Cantidad1.Value = 1;
                Cantidad1.Enabled = true;
                BtnAgregarCarrito1.Enabled = true;

                Cantidad3.Maximum = 12;
                Cantidad3.Value = 1;
                Cantidad3.Enabled = true;
                BtnAgregarCarrito2.Enabled = true;

                Cantidad5.Maximum = 12;
                Cantidad5.Value = 1;
                Cantidad5.Enabled = true;
                BtnAgregarCarrito3.Enabled = true;

                Cantidad2.Maximum = 12;
                Cantidad2.Value = 1;
                Cantidad2.Enabled = true;
                BtnAgregarCarrito4.Enabled = true;

                Cantidad4.Maximum = 12;
                Cantidad4.Value = 1;
                Cantidad4.Enabled = true;
                BtnAgregarCarrito5.Enabled = true;

                Cantidad6.Maximum = 12;
                Cantidad6.Value = 1;
                Cantidad6.Enabled = true;
                BtnAgregarCarrito6.Enabled = true;
           
        
        }

        public void Infomacion_Categoria(int Infcategoria, int scroll)
        {

            int cont = 0;


            Scroll = scroll;
            Categoria = Infcategoria;

            switch (Categoria)
            {
                case 1:

                    switch (Scroll)
                    {
                        case 1:

                            
                            //Contenido Scroll 1 categoria 1
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");
                            
                            imgLibro1.Image = Image.FromFile("demonio.jpg");
                            Titulo1.Text = "Titulo" + ": El Demonio y la Senorita Prym Una Novela";
                            Descripcion1.Text = "Una novela sobre la lucha entre el Bien y el Mal... y la constante búsqueda del ser humano por alcanzar la verdadera felicidad Una comunidad dividida por la codicia, la cobardía y el miedo. Un hombre perseguido por el fantasma de un pasado doloroso. Una joven en busca de la felicidad. Siete días, un breve período de tiempo durante el cual el Bien y el Mal librarán una batalla decisiva, y cada personaje decidirá a cuál de los dos bandos pertenece. Una pequeña aldea perdida en el tiempo y el espacio será el marco de esa inquietante lucha. Con la llegada de un extranjero, el pueblo se convierte en cómplice de una trama perversa que marcará para siempre la historia de sus habitantes.";
                            precio1 = 8.11;
                            Precios1.Text = "$" + precio1;
                            
                            imgLibro2.Image = Image.FromFile("Fahrenheit 451.jpg");
                            Titulo2.Text = "Titulo" + ": " + "Fahrenheit 451";
                            Descripcion2.Text = "Guy Montag pertenece a una extraña brigada de bomberos. Su misión, paradójicamente, no es la de sofocar incendios sino la de provocarlos para quemar libros. Ha sido bombero durante más de 10 años, y siempre le gustó su trabajó. Nunca cuestionó nada —ni la emoción de las salidas a medianoche ni el placer de ver las hojas arder— hasta que conoció a una niña de diecisiete años que le mostró un pasado en el que la gente no tenía miedo y a un profesor que le habló de un futuro en el que la gente podría ser libre. Y al fin Montag comprendió lo que tenía que hacer.";
                            precio2 = 12.75;
                            Precios2.Text = "$" + precio2;

                            imgLibro3.Image = Image.FromFile("Harry Potter.jpg");
                            Titulo3.Text = "Titulo" + ": " + "Harry Potter";
                            Descripcion3.Text = "Ser Harry Potter nunca ha sido tarea facil, menos aun desde que se ha convertido en un atareadisimo empleado del Ministerio de Magia, un hombre casado y padre de tres hijos. Y si Harry planta cara a un pasado que se resiste a quedar atras, su hijo menor, Albus Severus, ha de luchar contra el peso de una herencia familiar de la que el nunca ha querido saber nada. Cuando el destino conecte el pasado con el presente, padre e hijo deberan afrontar una verdad muy incomoda: a veces, la oscuridad surge de los lugares mas insospechados.";
                            precio3 = 14.99;
                            Precios3.Text = "$" + precio3;

                            imgLibro4.Image = Image.FromFile("La invención de Morel.jpg");
                            Titulo4.Text = "Titulo" + ": " + "La invención de Morel";
                            Descripcion4.Text = "La invención de Morel narra una extrana historia de amor protagonizada por un hombre y una mujer que viven existencias incompatibles en espacios y tiempos rivales. En ella, el talento de Adolfo Bioy Casares despliega una odisea de prodigios que, si en un primer momento no parecen admitir otra clave que la alucinacion o el simbolo, son luego plenamente descifrados mediante un solo postulado fantastico, pero no sobrenatural. "+"He discutido con su autor -escribe Jorge Luis Borges en el prologo que abre el volumen- los pormenores de su trama, la he releido; no me parece una imprecision o una hiperbole calificarla de perfecta.";
                            precio4 = 12.12;
                            Precios4.Text = "$" + precio4;

                            imgLibro5.Image = Image.FromFile("Nocturno.jpg");
                            Titulo5.Text = "Titulo" + ": " + "Nocturno";
                            Descripcion5.Text = "Un demonio inmortal está atrapado por su propia existencia, a vagar eternamente por el tiempo, vacío y sin esperanzas. Pero en mitad de la más absoluta oscuridad, un haz de anhelo y calor surge ante él. Su destino se cruza con el de una joven, que desconoce la verdad sobre sí misma, y sus mundos se fusionan. ¿Podrá un amor incondicional superar las barreras impuestas por la venganza y el peligro de una guerra inevitable? ¿Conseguirá la Luz estar en paz con las Sombras? Descubre un mundo melancólico y triste. Tierno, envolvente y sobrecogedor.";
                            precio5 = 23.0;
                            Precios5.Text = "$" + precio5;

                            imgLibro6.Image = Image.FromFile("El Marciano.jpg");
                            Titulo6.Text = "Titulo" + ": " + "El Marciano";
                            Descripcion6.Text = "Hace seis dias, el astronauta Mark Watney se convirtio en una de las primeras personas en caminar en Marte. Ahora, el esta seguro de que va a ser la primera persona en morir alli. Despues de que una tormenta de polvo casi lo mata y obliga a su tripulacion a evacuar mientras lo hacian muerto, Mark se encuentra atrapado y completamente solo, sin manera de siquiera dar una senal a la tierra de que esta vivo, y aunque el pudiera conseguir palabra hacia fuera, sus suministros se irian mucho antes de que el rescate pudiera llegar.";
                            precio6 = 16.47;
                            Precios6.Text = "$" + precio6;

                            
                            break;

                        case 2:

                            ResetearControlesCompra();
                            //Contenido Scroll 2 categoria 1
                            

                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");
                            imgLibro1.Image = Image.FromFile("La metamorfosis.jpg");
                            Titulo1.Text = "Titulo" + ": La metamorfosis";
                            Descripcion1.Text = "Del mito de un escritor enfermo, atormentado y poco exitoso en vida, ha emergido, poco a poco, la figura de un creador apasionado por el mundo, e interesado por las vicisitudes de su comunidad y la política de su tiempo. Así también, para el lector contemporáneo, más habituado que sus predecesores a la crueldad, el relato del exitoso y joven viajero que despierta una mañana como un escarabajo gigante, ha devenido, de sus raíces de pesadilla, en una obra maestra del humor más oscuro. Pero si el lector ríe, es solo para tomar distancia de la horrible situación a la que se enfrenta y así, evitar la repugnancia y el horror. Gregorio Samsa sufre con estoicismo cada página, sin encontrar al final, ni redención ni conocimiento en su mutación, tan inesperada como vergonzante. Se cuenta que las carcajadas de Kafka, mientras leía los episodios más escabrosos de sus relatos, sorprendían a sus amigos hasta el estupor; a lo que él explicaba que su risa era, en realidad, un muro de concreto. ¿Contra qué?, le preguntaban. Y el respondía: contra mí mismo, por supuesto.";
                            precio1 = 4.95;
                            Precios1.Text = "$" + precio1;

                            imgLibro2.Image = Image.FromFile("Filosofia de Hielo y Fuego.jpg");
                            Titulo2.Text = "Titulo" + ": " + "Filosofia de Hielo y Fuego";
                            Descripcion2.Text = "Conoces los secretos detras de los impresionantes personajes, increibles episodios y escenografias asombrosas de Juego de Tronos? Sabes de donde surgio todo el fascinante mundo de esta serie? Descubre que tiene que ver esta increible y exitosa saga de George R. R. Martin con conocidos filosofos como Maquiavelo o Nietzsche, escritores como Shakespeare o Thoreau, personajes historicos de la realeza y algunos terminos del psicoanalisis a traves de este maravilloso libro.";
                            precio2 = 15.53;
                            Precios2.Text = "$" + precio2;

                            imgLibro3.Image = Image.FromFile("Estoy bien.jpg");
                            Titulo3.Text = "Titulo" + ": " + "Estoy bien";
                            Descripcion3.Text = "El «más allá» nunca estuvo tan cerca. Si creía conocer las investigaciones de J. J. Benítez, se equivoca. Estoy bien es otra vuelta de tuerca en la producción literaria del autor navarro. Veamos algunos pensamientos de Juanjo Benítez sobre el delicado asunto de los «resucitados», como llama él a los muertos que han vuelto: «Estoy bien es tan increíble como cierto».«Se trata de 160 casos “al sur de la razón ». «Quizá este libro sea mucho más de lo que parece». «Estoy bien debe ser leído despacio, muy despacio». «El padre Azul (y su “gente ) se han sentado conmigo a la hora de escribirlo». «Si usted tiene miedo a la muerte, éste es su libro; si no es así, con más razón». «Algún día seremos esféricos». Al abrir Estoy bien, usted debería ver una luz. El concepto “vivo necesita ser revisado».";
                            precio3 = 21.70;
                            Precios3.Text = "$" + precio3;

                            imgLibro4.Image = Image.FromFile("La Naranja Mecanica.jpg");
                            Titulo4.Text = "Titulo" + ": " + "La Naranja Mecanica";
                            Descripcion4.Text = "La historia del nadsat-adolescente Alex y sus tres drugos-amigos en un mundo de crueldad y destruccion. Alex tiene, segun Burgess, los principales atributos humanos; amor a la agresion, amor al lenguaje, amor a la belleza. Pero es joven y no ha entendido aun la verdadera importancia de la libertad, la que disfruta de un modo tan violento. En cierto sentido vive en el Eden, y solo cuando cae (como en verdad le ocurre, desde una ventana) parece capaz de llegar a transformase en un verdadero ser humano.";
                            precio4 = 13.29;
                            Precios4.Text = "$" + precio4;

                            imgLibro5.Image = Image.FromFile("Juego de Ender.jpg");
                            Titulo5.Text = "Titulo" + ": " + "Juego de Ender";
                            Descripcion5.Text = "In order to develop a secure defense against a hostile alien race's next attack, government agencies breed child geniuses and train them as soldiers. A brilliant young boy, Andrew "+"Ender"+" Wiggin lives with his kind but distant parents, his sadistic brother Peter, and the person he loves more than anyone else, his sister Valentine. Peter and Valentine were candidates for the soldier-training program but didn't make the cutyoung Ender is the Wiggin drafted to the orbiting Battle School for rigorous military training. Ender's skills make him a leader in school and respected in the Battle Room, where children play at mock battles in zero gravity. Yet growing up in an artificial community of young soldiers Ender suffers greatly from isolation, rivalry from his peers, pressure from the adult teachers, and an unsettling fear of the alien invaders. His psychological battles include loneliness, fear that he is becoming like the cruel brother he remembers, and fanning the flames of devotion to his beloved sister. Is Ender the general Earth needs? But Ender is not the only result of the genetic experiments. The war with the Buggers has been raging for a hundred years, and the quest for the perfect general has been underway for almost as long.";
                            precio5 = 15.95;
                            Precios5.Text = "$" + precio5;

                            imgLibro6.Image = Image.FromFile("De la Tierra a la Luna.jpg");
                            Titulo6.Text = "Titulo" + ": " + "De la Tierra a la Luna";
                            Descripcion6.Text = "De la Tierra a la Luna es una novela «científica» y «satírica» del escritor Julio Verne. La obra, que comienza como una sátira del estereotipo estadounidense de la época, es un intento de describir por primera vez con minuciosidad científica los problemas que hay que resolver para lograr enviar un objeto a la Luna. Un intrépido proyecto aviva los corazones de los miembros del Gun-Club. Se trata de enviar a la Luna un proyectil que, auxiliado por el monstruoso cañón Columbiad, hará la función de una auténtica nave espacial para hacer realidad en el siglo XIX un viejo sueño: atravesar el espacio y descubrir un mundo lunar hasta entonces en penumbras. Tanto esta novela como "+"Alrededor de la Luna"+" sorprenden por el número de anticipaciones que presenta Julio Verne como el lugar del lanzamiento del proyectil, muy cercano al Cabo Cañaveral, lugar de lanzamiento de la NASA hoy en día. Otra novela espacial es "+"Héctor Servadac"+".";
                            precio6 = 5.95;
                            Precios6.Text = "$" + precio6;
                            
                            break;
                    }

                    break;
                case 2:
                    switch (Scroll)
                    {
                        case 1:
                            //Contenido Scroll 1 categoria 2
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");

                            imgLibro1.Image = Image.FromFile("La Cabaña Donde la Tragedia Se Encuentra Con la Eternidad.jpg");
                            Titulo1.Text = "Titulo" + ": La Cabaña: Donde la Tragedia Se Encuentra Con la Eternidad";
                            Descripcion1.Text = "La hija menor de Mackenzie Allen Phillips, Missy, desaparece durante unas vacaciones familiares. En el proceso de su busqueda se encuentran evidencias de que pudo haber sido brutalmente asesinada en una cabana abandonada en lo mas profundo de los bosques de Oregon. Transcurridos cuatro anos, Mack recibe una extrana carta, firmada por Dios, que la conmina a reunirse con el en el lugar donde la nina murio. A pesar de lo aparentemente absurdo de la situaticion, decide acudir a la cita y sumergirse de nuevo en su mas oscura pesadilla; lo que alli sucede camibara su vida siempre.";
                            precio1 = 10.61;
                            Precios1.Text = "$" + precio1;

                            imgLibro2.Image = Image.FromFile("Inferno.jpg");
                            Titulo2.Text = "Titulo" + ": " + "Inferno";
                            Descripcion2.Text = "El profesor de simbología en Harvard Robert Langdon despierta en un hospital a media noche. Desorientado y con una herida en la cabeza, no recuerda nada de las últimas treinta y seis horas, incluyendo como llegó allí o el origen de ese macabro objeto que los médicos han descubierto entre sus pertenencias.Con una incansable asesina persiguiéndoles por Florencia, Langdon y la ingeniosa doctora Sienna Brooks se ven obligados a huir.  Embarcados en un aterrador viaje, deberán desentramar una serie de códigos desarrollados por un brillante científico cuya obsesión con el fin del mundo sólo se compara con su pasión por una de las obras más influyentes jamás escritas: El infierno, el oscuro poema épico de Dante.";
                            precio2 = 13.80;
                            Precios2.Text = "$" + precio2;

                            imgLibro3.Image = Image.FromFile("El Juego del Ángel.jpg");
                            Titulo3.Text = "Titulo" + ": " + "El Juego del Ángel";
                            Descripcion3.Text = "En la turbulenta Barcelona de los años 20, un joven escritor obsesionado con un amor imposible recibe la oferta de un misterioso editor para escribir un libro como no ha existido nunca, a cambio de una fortuna y, tal vez, mucho más.Con un estilo deslumbrante e impecable el autor de La Sombra del Viento, nos transporta de nuevo a la Barcelona del Cementerio de los Libros Olvidados para ofrecernos una gran aventura de intriga, romance y tragedia, a través de un laberinto de traición y secretos donde el embrujo de los libros, la pasión y la amistad se conjugan en un relato magistral.";
                            precio3 = 12.13;
                            Precios3.Text = "$" + precio3;

                            imgLibro4.Image = Image.FromFile("La Venus de Cobre.jpg");
                            Titulo4.Text = "Titulo" + ": " + "La Venus de Cobre";
                            Descripcion4.Text = "De regreso de su periplo por Italia (La estatua de Bronce), el investigador Marco Didio Falco es contratado por el emperador para llevar a cabo un trabajo en Hacienda. Pero, desgraciadamente, Marco comete un imperdonable error contable que le lleva directamente a la mítica cárcel de Latumia,";
                            precio4 = 12.95;
                            Precios4.Text = "$" + precio4;

                            imgLibro5.Image = Image.FromFile("Los Asesinatos De La Escuela Priory.jpg");
                            Titulo5.Text = "Titulo" + ": " + "Los Asesinatos De La Escuela Priory";
                            Descripcion5.Text = "Una ola de crÌmenes amenaza Londres. En el comedor de la escuela Priory ha aparecido muerto y descuartizado uno de sus profesores. George Sttobart, un detective inglÈs de vacaciones en ParÌs con su novia, viajar· a Inglaterra para tratar de detener a un asesino que siempre va un paso por delante.";
                            precio5 = 10.66;
                            Precios5.Text = "$" + precio5;

                            imgLibro6.Image = Image.FromFile("La Sangre de los inocentes.jpg");
                            Titulo6.Text = "Titulo" + ": " + "La Sangre de los inocentes";
                            Descripcion6.Text = "Aventura en estado puro en una novela cuyo tema es de candente actualidad: los fanatismos religiosos. Soy espía y tengo miedo... Así empieza la crónica que escribe en el siglo XIII fray Julián sobre el cruel asedio a Montségur y la lucha entre cátaros y católicos. Siglos después, en 1939, un medievalista agnóstico emprende un peligroso viaje por el Berlín nazi en busca de su esposa de origen judío. En la actualidad, un grupo de musulmanes radicales se inmola en Frankfurt dejando tras de sí un mensaje críptico que pone en estado de alerta al Centro Antiterrorista de la Unión Europea, cuyos agentes, con la ayuda de los servicios secretos del Vaticano, intentarán desvelar un enigma que une la intolerancia de la Inquisición, la sinrazón fascista y el integrismo islámico en una frase: «Algún día alguien vengará la sangre de los inocentes».";
                            precio6 = 10.96;
                            Precios6.Text = "$" + precio6;
                            break;

                        case 2:
                            ResetearControlesCompra();
                            //Contenido Scroll 2 categoria 2
                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");

                            imgLibro1.Image = Image.FromFile("Los Crímenes Azules.jpg");
                            Titulo1.Text = "Titulo" + ": Los Crímenes Azules";
                            Descripcion1.Text = "Los cadáveres de dos jóvenes hallados en la orilla de un lago de forma casi simultánea. Un condado cuyos habitantes guardan oscuros secretos. Un prometedor agente especial de la Unidad de Análisis de Conducta del FBI asignado al caso. Un crimen similar acaecido casi dos décadas antes... Enrique Laso nos deslumbra con su primera incursión en el género policíaco con una novela inquietante, cargada de suspense y misterio. Tras vender cientos de miles de copias de sus libros en todo el mundo gracias al éxito de títulos como" + "El Rumor de los Muertos" + "o" + "Desde el Infierno";
                            precio1 = 13.95;
                            Precios1.Text = "$" + precio1;

                            imgLibro2.Image = Image.FromFile("La isla de las tormentas.jpg");
                            Titulo2.Text = "Titulo" + ": " + "La isla de las tormentas";
                            Descripcion2.Text = "En el año 1944 los aliados preparan en secreto una de las mayores operaciones militares de la historia: la invasión de la Europa ocupada por los nazis. Henry Faber, espía alemán, descubre que el desembarco se efectuará en Normadía e intenta llevar la noticia al Alto Mando alemán, pero nunca llegará a su destino...";
                            precio2 = 11.95;
                            Precios2.Text = "$" + precio2;

                            imgLibro3.Image = Image.FromFile("El perfume Historia de un asesino.jpg");
                            Titulo3.Text = "Titulo" + ": " + "El perfume: Historia de un asesino";
                            Descripcion3.Text = "Uno de los grandes fenómenos editoriales a escala mundial llevado al cine\nPara conseguir el favor de las damas y el dominio de los poderosos, Baptiste elabora un raro perfume que subyuga la voluntad de quien lo huele. La esencia proviene de los fluidos de jovencitas vírgenes y para conseguirla deberá convertirse en un asesino...";
                            precio3 = 10.95;
                            Precios3.Text = "$" + precio3;

                            imgLibro4.Image = Image.FromFile("Falcó.jpg");
                            Titulo4.Text = "Titulo" + ": " + "Falcó";
                            Descripcion4.Text = "La Europa turbulenta de los años treinta y cuarenta del siglo XX es el escenario de las andanzas de Lorenzo Falcó, ex contrabandista de armas, espía sin escrúpulos, agente de los servicios de inteligencia. Durante el otoño de 1936, mientras la frontera entre amigos y enemigos se reduce a una línea imprecisa y peligrosa, Falcó recibe el encargo de infiltrarse en una difícil misión que podría cambiar el curso de la historia de España. Un hombre y dos mujeres -los hermanos Montero y Eva Rengel- serán sus compañeros de aventura y tal vez sus víctimas, en un tiempo en el que la vida se escribe a golpe de traiciones y nada es lo que parece.";
                            precio4 = 19.95;
                            Precios4.Text = "$" + precio4;

                            imgLibro5.Image = Image.FromFile("Perdida.jpg");
                            Titulo5.Text = "Titulo" + ": " + "Perdida";
                            Descripcion5.Text = "En un caluroso día de verano, Amy y Nick se disponen a celebrar su quinto aniversario de bodas en North Carthage, a orillas del río Mississippi. Pero Amy desaparece esa misma mañana sin dejar rastro. A medida que la investigación policial avanza, las sospechas recaen sobre Nick. Sin embargo, Nick insiste en su inocencia. Es cierto que se muestra extrañamente evasivo y frío, pero ¿es un asesino?";
                            precio5 = 14.34;
                            Precios5.Text = "$" + precio5;

                            imgLibro6.Image = Image.FromFile("En La Cuerda Floja.jpg");
                            Titulo6.Text = "Titulo" + ": " + "En La Cuerda Floja";
                            Descripcion6.Text = "Augusto se rebela ante la sociedad y sus normas ante su incapacidad de adaptarse a ellas. El dinero, el amor, la vida adulta, son cosas para él irrelevantes, lo que desea es la libertad total más allá de la evasión que encuentra en el alcohol, el sexo y las drogas... Una misteriosa mujer llamada Lucky parece ser la encarnación perfecta de esa libertad primigenia, pero antes de alcanzar la felicidad, Augusto debe enfrentarse a su peor enemigo: el miedo.";
                            precio6 = 9.99;
                            Precios6.Text = "$" + precio6;

                            break;
                    }
                    break;
                case 3:
                    switch (Scroll)
                    {
                        case 1:
                            //contenido Scroll 1 Categoria 3
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");
<<<<<<< HEAD

                            imgLibro1.Image = Image.FromFile("Mathematics for the Nonmathematician.jpg");
                            Titulo1.Text = "Titulo" + ": Mathematics for the Nonmathematician";
                            Descripcion1.Text = "Practical, scientific, philosophical, and artistic problems have caused men to investigate mathematics. But there is one other motive which is as strong as any of these — the search for beauty. Mathematics is an art, and as such affords the pleasures which all the arts afford."+ "In this erudite, entertaining college-level text, Morris Kline, Professor Emeritus of Mathematics at New York University, provides the liberal arts student with a detailed treatment of mathematics in a cultural and historical context. The book can also act as a self-study vehicle for advanced high";
                            precio1 = 8.39;
                            Precios1.Text = "$" + precio1;

                            imgLibro2.Image = Image.FromFile("Algebra - The Very Basics.jpg");
                            Titulo2.Text = "Titulo" + ": " + "Algebra - The Very Basics";
                            Descripcion2.Text = "If you're looking for a gentle introduction to basic mathematics, look no further. This book picks you up at the very beginning and guides you through the foundations of algebra using lots of examples and no-nonsense explanations. Each chapter contains well-chosen exercises as well as all the solutions. No prior knowledge is required.";
                            precio2 = 11.95;
                            Precios2.Text = "$" + precio2;

                            imgLibro3.Image = Image.FromFile("Mathematics for the Practical Man.jpg");
                            Titulo3.Text = "Titulo" + ": " + "Mathematics for the Practical Man";
                            Descripcion3.Text = "“Books for self-instruction are constantly being sought. In this book mathematics, from algebra through calculus, has been treated in such a manner as to be clear to anyone. Men who wish to study a part of mathematics which they have not hitherto had, engineers who wish to refer to phases of mathematics which so easily slip from the memory, students who desire a simple reference book, will find this manual just the book for which they have been looking.”";
                            precio3 = 7.99;
                            Precios3.Text = "$" + precio3;

                            imgLibro4.Image = Image.FromFile("Mathematics A Complete Introduction.jpg");
                            Titulo4.Text = "Titulo" + ": " + "Mathematics: A Complete Introduction";
                            Descripcion4.Text = "Maths does not have to be difficult. This book, complete with exercises and answers, forms a course which will take you from beginner or intermediate level to being a confident mathematician. This book includes simple step-by-step explanations, to help you grasp new topics or those that have previously confused you; practice questions throughout, to help you embed your learning and improve your confidence; End of chapter summaries, to help you remember the key points you've learned; All in one great-value book, so you don't need any separate workbooks or coursebooks.";
                            precio4 = 14.46;
                            Precios4.Text = "$" + precio4;

                            imgLibro5.Image = Image.FromFile("The Princeton Companion to Mathematics.jpg");
                            Titulo5.Text = "Titulo" + ": " + "The Princeton Companion to Mathematics";
                            Descripcion5.Text = "This is a one-of-a-kind reference for anyone with a serious interest in mathematics. Edited by Timothy Gowers, a recipient of the Fields Medal, it presents nearly two hundred entries, written especially for this book by some of the world's leading mathematicians, that introduce basic mathematical tools and vocabulary; trace the development of modern mathematics; explain essential terms and concepts; examine core ideas in major areas of mathematics";
                            precio5 = 43.34;
                            Precios5.Text = "$" + precio5;

                            imgLibro6.Image = Image.FromFile("The Foundations of Mathematics.jpg");
                            Titulo6.Text = "Titulo" + ": " + "The Foundations of Mathematics";
                            Descripcion6.Text = "The transition from school mathematics to university mathematics is seldom straightforward. Students are faced with a disconnect between the algorithmic and informal attitude to mathematics at school, versus a new emphasis on proof, based on logic, and a more abstract development of general concepts, based on set theory.";
                            precio6 = 20.32;
                            Precios6.Text = "$" + precio6;
=======
>>>>>>> parent of f081458... Sin libros solo codigo repetitivo
                            break;

                        case 2:
                            ResetearControlesCompra();
                            //Contenido Scroll 2 Categoria 3
                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");
                            break;
                    }
                    break;
                case 4:
                    switch (Scroll)
                    {
                        case 1:
                            //Contenido Scroll 1 Categoria 4
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");
                            break;

                        case 2:
                            ResetearControlesCompra();
                            //Contenido Scroll 2 Categoria 4
                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");
                            break;
                    }
                    break;
                case 5:
                    switch (Scroll)
                    {
                        case 1:
                            //Contenido Scroll 1 Categoria 5
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");
                            break;

                        case 2:
                            ResetearControlesCompra();
                            //Contenido Scroll 2 Categoria 5
                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");
                            break;
                    }
                    break;
                case 6:
                    switch (Scroll)
                    {
                        case 1:
                            //Contenido Scroll 1 Categoria 6
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");
                            break;
                        case 2:
                            ResetearControlesCompra();
                            //Contenido Scroll 2 Categoria 6
                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");
                            break;
                    }
                    break;
                case 7:
                    switch (Scroll)
                    {
                        case 1:
                            //Contenido Scroll 1 Categoria 7
                            pictureBox3.Image = Image.FromFile("Circle-48.png");
                            pictureBox2.Image = Image.FromFile("Circle-482.png");
                            break;

                        case 2:
                            ResetearControlesCompra();
                            //Contemido Scroll 2 Categoria 7
                            pictureBox3.Image = Image.FromFile("Circle-482.png");
                            pictureBox2.Image = Image.FromFile("Circle-48.png");
                            break;
                    }
                    break;
            }
        }

        public void Animacion_Categoria(int categoria, int scroll) 
        {
            //desaparecer
            while (animacioncategoria <= 950)
            {
                animacioncategoria += 4;
                panelGaleria.Location = new Point(animacioncategoria, animacionscroll);
            }
            //Cambio de informacion


            //Metodo de cambio de informacion con switch
            Infomacion_Categoria(categoria, scroll);
            
            
            //Reaparecer
            animacioncategoria = -950;
            while (animacioncategoria <= 23)
            {
                animacioncategoria += 4;
                panelGaleria.Location = new Point(animacioncategoria, animacionscroll);
            }
        }


        void panelFondo_Wheel(object sender, MouseEventArgs e)
        {
            do
            {

                if (e.Delta > 0)
                {
                    //Scroll arriba

                    //Animacion desaparecer
                    while (animacionscroll >= -640)
                    {
                        animacionscroll -= 4;
                        panelGaleria.Location = new Point(26, animacionscroll);
                    }


                    //Cambio de informacion de la galeria

                    if (scroll == 1)
                    {
                        scroll = 2;
                  Infomacion_Categoria(categoria, scroll);
                    }
                    else if(scroll == 2)
                    {
                        scroll = 1;
                        Infomacion_Categoria(categoria, scroll);
                    }
                    else
                    {
                        MessageBox.Show("Error fatal scroll fuera de rango");
                    }

                    

                    //Animacion aparecer
                    animacionscroll = 640;
                    panelGaleria.Location = new Point(26, animacionscroll);

                    while (animacionscroll >= 5)
                    {
                        animacionscroll -= 4;
                        panelGaleria.Location = new Point(26, animacionscroll);
                    }
                }
                else
                {
                    //Scroll Abajo

                    //Animacion desaparecer
                    while (animacionscroll <= 606)
                    {
                        animacionscroll += 4;
                        panelGaleria.Location = new Point(26, animacionscroll);
                    }


                    //Cambio de informacion de la galeria

                    if (scroll == 1)
                    {
                        scroll = 2;
                    }
                    else if (scroll == 2)
                    {
                        scroll = 1;
                    }
                    else
                    {
                        MessageBox.Show("Error fatal scroll fuera de rango");
                    }

                    Infomacion_Categoria(categoria,scroll);

                    //Animacion aparecer
                    animacionscroll = -640;
                    panelGaleria.Location = new Point(26, animacionscroll);

                    while (animacionscroll <= 6)
                    {
                        animacionscroll += 4;
                        panelGaleria.Location = new Point(26, animacionscroll);
                    }
                }
                TimerMouseWheelRest.Start();
            } while (timermousewheelint != 0);
            
        }




        //Método para iniciar sesión
        public void IniciarSesion()
        {
            if (txtUsuarioBar.Text == Usuario)
            {
                if (txtPAsswordBar.Text == contraseña)
                {
                    Nombre = "Invitado";
                    LblUsuario.Text = Nombre + "!";
                    Saludo = "¡Hola";
                    lblSaludo.Text = Saludo;
                    loginBar.Size = new Size(width: 280, height: 0);
                    loginBar.Enabled = false;
                    txtPAsswordBar.Clear();
                    txtUsuarioBar.Clear();
                    login = true;

                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPAsswordBar.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioBar.Clear();
            }
        }

        public void ExtenderLoginBar()
        {
            if (loginBar.Enabled == false)
            {
                loginBar.Size = new Size(width: 280, height: 200);
                loginBar.Enabled = true;
                PopUpCarrito.Size = new Size(width: 0, height: 0);
                PopUpCarrito.Enabled = false;
                PopUpCarrito.Visible = false;
            }
            else if (loginBar.Enabled == true)
            {
                loginBar.Enabled = false;
                loginBar.Size = new Size(width: 280, height: 0);

            }
            
        }
 
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void Principal_Load(object sender, EventArgs e)
        {
            panelHola.BringToFront();
            PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            loginBar.BringToFront();
            PopUpCarrito.BringToFront();
            lblSaludo.Text = "Aún no haz";
            LblUsuario.Text = "Iniciado Sesión";
            
        }

        private void BtnIngresarBar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void BtnCerrarGaleria_Click(object sender, EventArgs e)
        {

            lblNombreCategoriaBar.Text = "";
            
        }

        private void ocultarLoginBar()
        {
            if (loginBar.Enabled == true)
            {
                loginBar.Size = new Size(width: 280, height: 0);
                loginBar.Enabled = false;
            }
        }

        private void BtnCat1_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            panelHola.SendToBack();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            //Variable categoria para el paramentro de la clase informacion
            categoria = 1;
            //Arriba
            scroll = 1;
            ocultarLoginBar();
            Animacion_Categoria(categoria,scroll);
            lblNombreCategoriaBar.Text = BtnCat1.Text;

        }

        private void BtnCat2_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelHola.SendToBack();
            //Variable categoria para el paramentro de la clase informacion
            categoria = 2;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat2.Text;
        }

        private void BtnCat3_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelHola.SendToBack();
            //Variable categoria para el paramentro de la clase informacion
            categoria = 3;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat3.Text;
        }

        private void BtnCat4_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelHola.SendToBack();
            //Variable categoria para el paramentro de la clase informacion
            categoria = 4;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat4.Text;
        }

        private void BtnCat5_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelHola.SendToBack();
            //Variable categoria para el paramentro de la clase informacion
            categoria = 5;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat5.Text;
        }

        private void BtnCat6_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelHola.SendToBack();
            //Variable categoria para el paramentro de la clase informacion
            categoria = 6;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat6.Text;
        }

        private void BtnCat7_Click(object sender, EventArgs e)
        {
            ResetearControlesCompra();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panelHola.SendToBack();
            //Variable categoria para el paramentro de la clase informacion
            categoria = 7;
            //Arriba
            scroll = 1;

            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat7.Text;
        }

        private void BtnCat7_MouseHover(object sender, EventArgs e)
        {
            while (anchopanel <= 178)
            {
                anchopanel = anchopanel + 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel,630); 
            }
      
        }

        private void BtnCat7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnCat7_MouseLeave_1(object sender, EventArgs e)
        {
            while (anchopanel >= 60)
            {
                anchopanel = anchopanel - 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            }
        }

        private void PanelCategorias_MouseHover(object sender, EventArgs e)
        {
            while (anchopanel <= 178)
            {
                anchopanel = anchopanel + 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            }
        }

        private void PanelCategorias_MouseLeave(object sender, EventArgs e)
        {
            while (anchopanel >= 60)
            {
                anchopanel = anchopanel - 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            }
        }

       

        private void BtnUserBar_Click(object sender, EventArgs e)
        {
            if (login)
            {

            }
            else
            {
                ExtenderLoginBar();
            }
        }

        //Botton Carrito

        private void button1_Click(object sender, EventArgs e)
        {
            if (PopUpCarrito.Enabled == false)
            {
                PopUpCarrito.Location = new Point(535,2);
             
                
                PopUpCarrito.Size = new Size(width: 400, height: 340);
                PopUpCarrito.Enabled = true;
                PopUpCarrito.Visible = true;
                loginBar.Enabled = false;
                loginBar.Size = new Size(width: 280, height: 0);
            }
            else if (PopUpCarrito.Enabled == true)
            {
                PopUpCarrito.Size = new Size(width: 0, height: 0);
                PopUpCarrito.Enabled = false;
                PopUpCarrito.Visible = false;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (login == false)
            {
               DialogResult Mensaje = MessageBox.Show("¡Necesitas Iniciar Sesión!", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

               if (Mensaje == DialogResult.OK)
               {
                   //Login loginVentana = new Login();
                   txtUsuarioLogin.Focus();
                   PopUpCarrito.Size = new Size(width: 0, height: 0);
                   PopUpCarrito.Enabled = false;
                   PopUpCarrito.Visible = false;
                   LoginPanel.BringToFront();
                   LoginPanel.Size = new Size(width: 405, height: 250);
                   LoginPanel.Location = new Point(228, 163);
                   login = true;

               }
           

            }
            else
            {
                Facturacion factura = new Facturacion();
                
                PopUpCarrito.Size = new Size(width: 0, height: 0);
                PopUpCarrito.Enabled = false;
                PopUpCarrito.Visible = false;
                factura.Show();
                factura.BringToFront();
                
            }
        }
  
        private void panel9_Scroll(object sender, ScrollEventArgs e)
        {
          
            
        }


        private void TimerMouseWheelRest_Tick(object sender, EventArgs e)
        {
            timermousewheelint = 0;
            TimerMouseWheelRest.Stop();
        }

        private void BtnCerrarLogin_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            LoginPanel.Size = new Size(width: 405, height: 0);
            LoginPanel.Location = new Point(910, 311);

        }

        private void BtnMostrarPassword_Click(object sender, EventArgs e)
        {
            if (txtPasswordLogin.UseSystemPasswordChar == true)
            {
                
                BtnMostrarPassword.BackgroundImage = Image.FromFile("Invisible-48.png");
                txtPasswordLogin.UseSystemPasswordChar = false;
            }
            else if (txtPasswordLogin.UseSystemPasswordChar == false)
            {
                BtnMostrarPassword.BackgroundImage = Image.FromFile("Visible-48.png");
                txtPasswordLogin.UseSystemPasswordChar = true;
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            

            if (txtUsuarioLogin.Text == Usuario)
            {

                if (txtPasswordLogin.Text == contraseña)
                {

                    Nombre = "Invitado";
                    LblUsuario.Text = Nombre + "!";
                    Saludo = "¡Hola";
                    lblSaludo.Text = Saludo;
                    loginBar.Size = new Size(width: 280, height: 0);
                    loginBar.Enabled = false;
                    txtUsuarioBar.Clear();
                    txtPAsswordBar.Clear();
                    login = true;
                    facturacion.Show();
                    LoginPanel.Visible = false;
                    LoginPanel.Size = new Size(width: 405, height: 0);
                    LoginPanel.Location = new Point(910, 311);
                    
                    

                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPasswordLogin.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuarioLogin.Clear();
              
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (scroll == 1)
            {
            
            
            }else
	{
              scroll = 1;

                //Scroll arriba

                //Animacion desaparecer
                while (animacionscroll >= -640)
                {
                    animacionscroll -= 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }


                //Cambio de informacion de la galeria

                Infomacion_Categoria(categoria, scroll);

                //Animacion aparecer
                animacionscroll = 640;
                panelGaleria.Location = new Point(26, animacionscroll);

                while (animacionscroll >= 5)
                {
                    animacionscroll -= 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (scroll == 2)
            {
          
            }
            else
            {
                scroll = 2;
                //Scroll Abajo

                //Animacion desaparecer
                while (animacionscroll <= 606)
                {
                    animacionscroll += 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }


                //Cambio de informacion de la galeria

                Infomacion_Categoria(categoria, scroll);

                //Animacion aparecer
                animacionscroll = -640;
                panelGaleria.Location = new Point(26, animacionscroll);

                while (animacionscroll <= 6)
                {
                    animacionscroll += 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }
            }
            
        }


        //Codigo para agregar libros al carrito

       

        private void BtnAgregarCarrito1_Click(object sender, EventArgs e)
        {
            Carritopop.Rows.Add(true,Titulo1.Text, Cantidad1.Value,"$"+precio1,"X");
            Cantidad1.Maximum = Cantidad1.Maximum - Cantidad1.Value;

            if (Cantidad1.Maximum > 0)
            {
                Cantidad1.Value = 1;
            }
            else 
            {
                Cantidad1.Value = 0;
                BtnAgregarCarrito1.Enabled = false;
                Cantidad1.Enabled = false;
            }
        }

        public void Carritopop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Carritopop.CurrentCell.ColumnIndex == 4)
            {
                var row = Carritopop.CurrentRow;
                Carritopop.Rows.Remove(row);

            }
        }

        private void BtnAgregarCarrito2_Click(object sender, EventArgs e)
        {

            Carritopop.Rows.Add(true, Titulo2.Text, Cantidad2.Value, "$" + precio2, "X");
            Cantidad2.Maximum = Cantidad2.Maximum - Cantidad2.Value;

            if (Cantidad2.Maximum > 0)
            {
                Cantidad2.Value = 1;
            }
            else
            {
                Cantidad2.Value = 0;
                BtnAgregarCarrito2.Enabled = false;
                Cantidad2.Enabled = false;
            }


        }

        private void BtnAgregarCarrito3_Click(object sender, EventArgs e)
        {
            Carritopop.Rows.Add(true, Titulo3.Text, Cantidad3.Value, "$" + precio3, "X");
            Cantidad3.Maximum = Cantidad3.Maximum - Cantidad3.Value;

            if (Cantidad3.Maximum > 0)
            {
                Cantidad3.Value = 1;
            }
            else
            {
                Cantidad3.Value = 0;
                BtnAgregarCarrito3.Enabled = false;
                Cantidad3.Enabled = false;
            }
        }

        private void BtnAgregarCarrito4_Click(object sender, EventArgs e)
        {
            Carritopop.Rows.Add(true, Titulo4.Text, Cantidad4.Value, "$" + precio4, "X");
            Cantidad4.Maximum = Cantidad4.Maximum - Cantidad4.Value;

            if (Cantidad4.Maximum > 0)
            {
                Cantidad4.Value = 1;
            }
            else
            {
                Cantidad4.Value = 0;
                BtnAgregarCarrito4.Enabled = false;
                Cantidad4.Enabled = false;
            }
        }

        private void BtnAgregarCarrito5_Click(object sender, EventArgs e)
        {
            Carritopop.Rows.Add(true, Titulo5.Text, Cantidad5.Value, "$" + precio5, "X");
            Cantidad5.Maximum = Cantidad5.Maximum - Cantidad5.Value;

            if (Cantidad5.Maximum > 0)
            {
                Cantidad5.Value = 1;
            }
            else
            {
                Cantidad5.Value = 0;
                BtnAgregarCarrito5.Enabled = false;
                Cantidad5.Enabled = false;
            }
        }

        private void BtnAgregarCarrito6_Click(object sender, EventArgs e)
        {
            Carritopop.Rows.Add(true, Titulo6.Text, Cantidad6.Value, "$" + precio6, "X");
            Cantidad6.Maximum = Cantidad6.Maximum - Cantidad6.Value;

            if (Cantidad6.Maximum > 0)
            {
                Cantidad6.Value = 1;
            }
            else
            {
                Cantidad6.Value = 0;
                BtnAgregarCarrito6.Enabled = false;
                Cantidad6.Enabled = false;
            }
        }



     




        /*
          try
            {
                System.Diagnostics.Process.Start("http://www.microsoft.com");
            }
            catch { }
         */
    }
}
