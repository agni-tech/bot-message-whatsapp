namespace WhatsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhatsAppSendMessage w = new WhatsAppSendMessage();
            //w.SendMessageWithImage("Hello World, Filipe Brito", "C:\\Users\\agbct\\Pictures\\temp\\teste.jpg", "@filipebritodev");
            w.SendMessageWithEmoji("Hello World, Agni Campos", new List<string> { "robo" }, "@agni-tech");
        }
    }
}