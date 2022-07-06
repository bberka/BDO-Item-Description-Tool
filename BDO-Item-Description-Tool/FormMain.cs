using BDO_Data.DescriptionManager;
namespace BDO_Item_Description_Tool
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private readonly string PAColorEnd = "<PAOldColor>";
        private readonly string  PAColorStart = "<PAColor0xFF";
        
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonYellow.BackColor = DescriptionHelper.PAColorYellow;
            
            buttonBlue.BackColor = DescriptionHelper.PAColorBlue;
            buttonGreen.BackColor = DescriptionHelper.PAColorGreen;
            buttonPurple.BackColor = DescriptionHelper.PAColorPurple;
            buttonRed.BackColor = DescriptionHelper.PAColorRed;
            buttonYellow.BackColor = DescriptionHelper.PAColorYellow;
            
            trackBarGreen.Scroll += LoadColor;
            trackBarRed.Scroll += LoadColor;
            trackBarBlue.Scroll += LoadColor;
            ValueRed.ValueChanged += LoadColor;
            ValueBlue.ValueChanged += LoadColor;
            ValueGreen.ValueChanged += LoadColor;
            

        }
        private void LoadColor(object sender, EventArgs e)
        {
            textBoxColorValue.Text = "";
            ValueGreen.Text = trackBarGreen.Value.ToString();
            ValueRed.Text = trackBarRed.Value.ToString();
            ValueBlue.Text = trackBarBlue.Value.ToString();
            red = Convert.ToInt32(ValueRed.Text);
            green = Convert.ToInt32(ValueGreen.Text);
            blue = Convert.ToInt32(ValueBlue.Text);
            trackBarBlue.Value = blue;
            trackBarGreen.Value = green;
            trackBarRed.Value = red;
            panelColorView.BackColor = Color.FromArgb(red, green, blue);
        }


        private void buttonLoadColorValue_Click(object sender, EventArgs e)
        {
            //var RGBText = $"{red};{green};{blue}";
            Color myColor = Color.FromArgb(red,green,blue);

            var paColorEndVal = DescriptionHelper.PAColorEnd;
            if (textBoxColorValue.Text.Contains(paColorEndVal)) textBoxColorValue.Text = "";
            textBoxColorValue.Text = DescriptionHelper.GetPAColorText(textBoxColorValue.Text, myColor);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            var color = DescriptionHelper.PAColorYellow;
            trackBarBlue.Value = color.B;
            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            LoadColor(null, null);

        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            var color = DescriptionHelper.PAColorRed;
            trackBarBlue.Value = color.B;
            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            LoadColor(null, null);
            
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            var color = DescriptionHelper.PAColorGreen;
            trackBarBlue.Value = color.B;
            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            LoadColor(null, null);
            
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            var color = DescriptionHelper.PAColorBlue;
            trackBarBlue.Value = color.B;
            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            LoadColor(null, null);
            
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            var color = DescriptionHelper.PAColorPurple;
            trackBarBlue.Value = color.B;
            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            LoadColor(null, null);
        }
    }
}