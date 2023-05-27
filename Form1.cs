using System.Collections;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace demoExamen
{
    public partial class Form1 : Form
    {
        public bool iniciado = false;
        public string palabra = "";
        int contador = 0;
        int contadorPaneles = 0;
        int oportunidades = 0;
        bool acertaste = false;
        int contadorverdes = 0;

        Color[] colores = new Color[3] { Color.Gray, Color.Yellow, Color.Green };
        
        Button[] comprobar1= new Button[5];
        Button[] comprobar2 = new Button[5];
        Button[] comprobar3 = new Button[5];
        Button[] comprobar4 = new Button[5];
        Button[] comprobar5 = new Button[5];


        Button[] buttons1 = new Button[5];
        Button[] buttons2 = new Button[5];
        Button[] buttons3 = new Button[5];
        Button[] buttons4 = new Button[5];
        Button[] buttons5 = new Button[5];

        Button[][] ArrayButtons= new Button[5][];
        Button[][] ArrayComprobar = new Button[5][];

        Panel[] paneles = new Panel[5];

        Char[] palabra_letras = new Char[5];   
        Char[] comprobar= new Char[5];




        public Form1()
        {
            InitializeComponent();


            // tooltips de menu de ayuda
            toolTip1.SetToolTip(button2, "Introduir paraula de 5 lletres");
            toolTip1.SetToolTip(button71, "Reiniciar joc amb la mateixa paraula");
            toolTip1.SetToolTip(enter, "Introduir paraula quan tinguis les 5 lletres");
            toolTip1.SetToolTip(borrar, "Borra l'ultima lletra");

            //evento introduir lletra per tot el teclat

            b_q.Click += new EventHandler(introducirLetra);
            b_w.Click += new EventHandler(introducirLetra);
            b_e.Click += new EventHandler(introducirLetra);
            b_r.Click += new EventHandler(introducirLetra);
            b_t.Click += new EventHandler(introducirLetra);
            b_y.Click += new EventHandler(introducirLetra);
            b_u.Click += new EventHandler(introducirLetra);
            b_i.Click += new EventHandler(introducirLetra);
            b_o.Click += new EventHandler(introducirLetra);
            b_p.Click += new EventHandler(introducirLetra);
            b_a.Click += new EventHandler(introducirLetra);
            b_s.Click += new EventHandler(introducirLetra);
            b_d.Click += new EventHandler(introducirLetra);
            b_f.Click += new EventHandler(introducirLetra);
            b_g.Click += new EventHandler(introducirLetra);
            b_h.Click += new EventHandler(introducirLetra);
            b_j.Click += new EventHandler(introducirLetra);
            b_k.Click += new EventHandler(introducirLetra);
            b_l.Click += new EventHandler(introducirLetra);
            b_ç.Click += new EventHandler(introducirLetra);
            b_z.Click += new EventHandler(introducirLetra);
            b_x.Click += new EventHandler(introducirLetra);
            b_c.Click += new EventHandler(introducirLetra);
            b_v.Click += new EventHandler(introducirLetra);
            b_b.Click += new EventHandler(introducirLetra);
            b_n.Click += new EventHandler(introducirLetra);
            b_m.Click += new EventHandler(introducirLetra);
          

            paneles[0] = panel2;
            paneles[1] = panel4;
            paneles[2] = panel6;
            paneles[3] = panel8;
            paneles[4] = panel10;


            //guardas los botones donde se ponen las letras
            buttons1[0] = letra10;
            buttons1[1] = letra20;
            buttons1[2] = letra30;
            buttons1[3] = letra40;
            buttons1[4] = letra50;

            buttons2[0] = letra11;
            buttons2[1] = letra21;
            buttons2[2] = letra31;
            buttons2[3] = letra41;
            buttons2[4] = letra51;

            buttons3[0] = letra12;
            buttons3[1] = letra22;
            buttons3[2] = letra32;
            buttons3[3] = letra42;
            buttons3[4] = letra52;

            buttons4[0] = letra13;
            buttons4[1] = letra23;
            buttons4[2] = letra33;
            buttons4[3] = letra43;
            buttons4[4] = letra53;

            buttons5[0] = letra14;
            buttons5[1] = letra24;
            buttons5[2] = letra34;
            buttons5[3] = letra44;
            buttons5[4] = letra54;

            ArrayButtons[0] = buttons1;
            ArrayButtons[1] = buttons2;
            ArrayButtons[2] = buttons3;
            ArrayButtons[3] = buttons4;
            ArrayButtons[4] = buttons5;
           
            //botones donde saldra la respuesta
            comprobar1[0] = respuesta10;
            comprobar1[1] = respuesta20;
            comprobar1[2] = respuesta30;
            comprobar1[3] = respuesta40;
            comprobar1[4] = respuesta50;

            comprobar2[0] = respuesta11;
            comprobar2[1] = respuesta21;
            comprobar2[2] = respuesta31;
            comprobar2[3] = respuesta41;
            comprobar2[4] = respuesta51;

            comprobar3[0] = respuesta12;
            comprobar3[1] = respuesta22;
            comprobar3[2] = respuesta32;
            comprobar3[3] = respuesta42;
            comprobar3[4] = respuesta52;

            comprobar4[0] = respuesta13;
            comprobar4[1] = respuesta23;
            comprobar4[2] = respuesta33;
            comprobar4[3] = respuesta43;
            comprobar4[4] = respuesta53;

            comprobar5[0] = respuesta14;
            comprobar5[1] = respuesta24;
            comprobar5[2] = respuesta34;
            comprobar5[3] = respuesta44;
            comprobar5[4] = respuesta54;

            ArrayComprobar[0] = comprobar1;
            ArrayComprobar[1] = comprobar2;
            ArrayComprobar[2] = comprobar3;
            ArrayComprobar[3] = comprobar4;
            ArrayComprobar[4] = comprobar5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBox1.Visible = true;
            button2.Visible = true;


        }
        private void borrarLetra(object sender, EventArgs e)
        {

            
            
            

        }
            
            

    


        private void introducirLetra(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = button.Text;

            for (int i = 0; i < paneles.Length; i++)
            {
                if (paneles[i].Tag != null && paneles[i].Tag.ToString() == "foco")

                {
                    if (contador < 5)
                    {
                        Button [] listaBotones = ArrayButtons[i];
                        listaBotones[contador].Text = text;

                    }
                    
                }
            }

            contador++;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length != 5)
            {


                MessageBox.Show("La palabra tiene que ser igual a 5 letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";

            }
            else
            {
                palabra = textBox1.Text;
                textBox1.Visible = false;
                button2.Visible = false;
   
                panel1.Visible = true;

                button71.Visible = true;
                palabra_letras = palabra.ToUpper().ToCharArray();            

            }

        }

        private void letra1_Click(object sender, EventArgs e)
        {

        }

        private void b_p_Click(object sender, EventArgs e)
        {
            
        }
        
        private void enter_Click(object sender, EventArgs e)
        {
            oportunidades++;
            iniciado = true;
            contadorverdes = 0;


            for (int i = 0; i < paneles.Length; i++)
            {
                if (paneles[i].Tag != null && paneles[i].Tag.ToString() == "foco")
                {
                    bool encontrado;
                    Button[] listabotones = ArrayButtons[i];
                    Button[] listacomprobar = ArrayComprobar[i];

                    for (int m = 0; m < listabotones.Length; m++)
                    {

                        encontrado = false;
                        if (Char.Parse(listabotones[m].Text) == palabra_letras[m])
                        {
                            listacomprobar[m].Text = listabotones[m].Text;
                            
                            listacomprobar[m].BackColor = colores[2];
                            encontrado = true;

                            foreach (Control control in teclado.Controls)
                            {
                                if (control is Button && control.Text == listacomprobar[m].Text)
                                {
                                    control.BackColor = colores[2];
                                }
                            }
                            



                        }
                        else
                        {
                            listacomprobar[m].Text = listabotones[m].Text;
                            listacomprobar[m].BackColor = colores[0];
                            foreach (Control control in teclado.Controls)
                            {
                                if (control is Button && control.Text == listacomprobar[m].Text)
                                {
                                    control.BackColor = colores[0];
                                }
                            }
                        }
                        if (!encontrado)
                        {
                            for (int n = 0; n < palabra_letras.Length; n++)
                            {
                                if (!encontrado && Char.Parse(listabotones[m].Text) == palabra_letras[n])
                                {
                                    listacomprobar[m].Text = listabotones[m].Text;
                                    listacomprobar[m].BackColor = colores[1];
                                    encontrado = true;
                                    foreach (Control control in teclado.Controls)
                                    {
                                        if (control is Button && control.Text == listacomprobar[m].Text)
                                        {
                                            control.BackColor = colores[1];
                                        }
                                    }
                                }
                            }
                        }

                        if (listacomprobar[m].BackColor == Color.Green)
                        {
                            contadorverdes++;
                            
                        }
                    }
                }
            
            }
            if (contadorverdes == 5)
            {
               
                    DialogResult resultat = MessageBox.Show("HA GUANYAT LA PARTIDA EN "+oportunidades+" Oportunitats", "Informacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3.Visible = true;
     

            }

            paneles[contadorPaneles].Tag = "";
            contadorPaneles++;
            if (contadorPaneles >= 4)
            {
                contadorPaneles = 4;
            }
            paneles[contadorPaneles].Tag = "foco";
            
            contador = 0;

        }
        private void resetear(object sender, EventArgs e)
        {
            for (int i = 0; i < paneles.Length; i++)
            {
                paneles[i].Tag = "";

            }
            paneles[0].Tag = "foco";

            for (int i = 0; i < ArrayButtons.Length; i++)
            {
                Button[] botones = ArrayButtons[i];
                Button[] botonesderecha = ArrayComprobar[i];
                for (int b = 0; b < botones.Length ; b++)
                {
                    botones[b].Text = "";
                    botonesderecha[b].Text = "";
                    botonesderecha[b].BackColor= Color.White;
                }
            }

            foreach (Button botones in teclado.Controls)
            {
                botones.BackColor = Color.White;
            }
            contador = 0;
            contadorPaneles= 0;
            contadorverdes= 0;
            oportunidades= 0;
            acertaste = false;
            iniciado = false;

        }
        private void button71_Click(object sender, EventArgs e)
        {
            if (iniciado == true)
            {
                DialogResult resultat = MessageBox.Show("Vols tornar a començar", "Informacio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultat == DialogResult.Yes)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.StartPosition = FormStartPosition.Manual;
                    form1.Location = new Point(this.Left, this.Top);
                    form1.ShowDialog();

                }
                else if (resultat == DialogResult.No)
                {
                    MessageBox.Show("Acción cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (contador > 0 )
            {
                for (int i = 0; i < paneles.Length; i++)
                {
                    if (paneles[i].Tag != null && paneles[i].Tag.ToString() == "foco")

                    {
                        if (contador >= 0)
                        {
                            Button[] listabotones = ArrayButtons[i];
                            listabotones[contador - 1].Text = "";

                        }

                    }
                }
                contador--;
            }
 

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Label label1 = new Label();
            label1.Text = "Has ganado con " + oportunidades.ToString() + " Oportunidades!";
            label1.Location = new Point(350,674);
            label1.Font = new Font(Font, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.AutoSize = true;
            
            this.Controls.Add(label1);


            int xsumar = 0;
            for (int i = 0; i < ArrayComprobar.Length; i++)
            {
                Button[] botones = ArrayComprobar[i];
                
                int x = 350; // posición x del primer botón
                int y =693+xsumar; // posición y del primer botón
                int espacioEntreBotones = 10; // espacio deseado entre botones

                for (int m = 0; m < botones.Length; m++)
                {
                    Button nuevoBoton = new Button();
                    nuevoBoton.BackColor = botones[m].BackColor;
                    nuevoBoton.ForeColor = botones[m].ForeColor;
                    nuevoBoton.Location = new Point(x, y);
                    nuevoBoton.Size = new Size(20, 20);
                    this.Controls.Add(nuevoBoton); // Agregar el nuevo botón al formulario
                    x += nuevoBoton.Width + espacioEntreBotones;
                }
                xsumar += 20;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


    
}