using static System.Formats.Asn1.AsnWriter;

namespace NGDetector
{
    public partial class frmDetector : Form
    {
        public frmDetector()
        {
            InitializeComponent();
        }        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btImgBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Jpeg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png|Gif Files (*.gif)|*.gif|All Files (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbImgPath.Text = openFileDialog1.FileName;
                this.pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        private void btnPredict_Click(object sender, EventArgs e)
        {
            var imageBytes = File.ReadAllBytes(this.tbImgPath.Text);
            NgMLModel.ModelInput sampleData = new NgMLModel.ModelInput()
            {
                ImageSource = imageBytes,
            };

            // Make a single prediction on the sample data and print results.
            var sortedScoresWithLabel = NgMLModel.PredictAllLabels(sampleData);
            Console.WriteLine($"{"Class",-40}{"Score",-20}");
            Console.WriteLine($"{"-----",-40}{"-----",-20}");
            var s = "";
            
            foreach (var score in sortedScoresWithLabel)
            {
                comboBox1.Items.Add(score.Key.ToString() + "|" + score.Value.ToString());
                if (score.Value >= 0.4)
                {
                    if (score.Key == "NotOK")
                    {
                        this.label5.Text = "Suy dinh dưỡng";
                        this.label6.Text = score.Value.ToString();
                    }else
                    {
                        this.label5.Text = "Sức khỏe bình thường";
                        this.label6.Text = "";
                    }    
                    break;
                }                
            }
        }
    }
    
}
