namespace ParcialCalculadora
{
    public partial class Form1 : Form
    {
        double primernumero = 0, segundonumero = 0;
            char operador;
        public Form1()
        {
            InitializeComponent();
        }

        clases.sumando objectosuma = new clases.sumando();
        clases.restando objetoresta = new clases.restando();
        clases.multiplicando objetomultiplicacion = new clases.multiplicando();
        clases.divisdiendo objetodivision = new clases.divisdiendo();



        private void ingresarcantidades(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (BarraGrande.Text == "0") 
                BarraGrande.Text = "";

            BarraGrande.Text += boton.Text;

     
        }


        private void ingresaroperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            primernumero = Convert.ToDouble(BarraGrande.Text);
            operador = Convert.ToChar(boton.Tag);

            BarraGrande.Text = "0";
        }

        private void iguals(object sender, EventArgs e)
        {
            segundonumero = Convert.ToDouble(BarraGrande.Text);

            double sum, res, mul, div;
            switch(operador)
            {
                case '+':
                    sum = objectosuma.suma((primernumero), (segundonumero));
                    BarraGrande.Text = sum.ToString();
                    break;

                case '-':
                    res = objetoresta.resta((primernumero), (segundonumero));
                    BarraGrande.Text = res.ToString();
                    break;


                case 'x':
                    mul = objetomultiplicacion.multiplicar((primernumero), (segundonumero));
                    BarraGrande.Text = mul.ToString();
                    break;

                case '/':
                    div = objetodivision.odividir((primernumero), (segundonumero));
                    BarraGrande.Text = div.ToString();
                    break;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clsBotonCircular18_Click(object sender, EventArgs e)
        {
            BarraGrande.Text = BarraGrande.Text + ".";
  
        }

        private void clsBotonCircular15_Click(object sender, EventArgs e)
        {
            primernumero = 0;
            segundonumero = 0;
            operador = '\0';
            BarraGrande.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ce_Click(object sender, EventArgs e)
        {
            BarraGrande.Text = "0";
        }

        private void historia(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}