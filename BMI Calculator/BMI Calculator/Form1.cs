using System;
using System.IO;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        private BMICalculator[] bmiHistory = new BMICalculator[5];     // Array لتخزين آخر 5 حسابات
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent(); // بيجهز الفورم
            comboBox1.SelectedIndex = 0; // نخلي الطول الافتراضي هو المتر
        }

        private void Calcbutton_Click(object sender, EventArgs e)     // لما المستخدم يضغط زر الحساب

        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Choose the unit (Meter or Centimeter)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // ناخد المدخلات
                double height = double.Parse(textBoxHeight.Text);
                double weight = double.Parse(textBoxWeight.Text);
                // لو كانت الوحدة سنتيمتر نحولها لمتر
                if (comboBox1.SelectedItem.ToString() == "Centimeter")
                    height /= 100;
                BMICalculator calc = new BMICalculator(height, weight);                // نحسب القيمة

                double bmi = Math.Round(calc.BMIValue, 2);

                // التصنيف والنصيحة
                BMICategory category = BMIClassifier.ClassifyBMI(bmi);
                string description = BMIClassifier.GetCategoryDescription(category);
                string advice = BMIClassifier.GetAdvice(category);

                // عرض النتيجة
                Resultlabel.Text = $"BMI: {bmi}\nCategory: {description}\nAdvice: {advice}";

                // حفظ في array
                bmiHistory[currentIndex] = calc;
                currentIndex = (currentIndex + 1) % bmiHistory.Length;

                // حفظ في ملف
                SaveToFile(bmi, description, advice);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)     // لما المستخدم يضغط زر المسح
        {
            textBoxHeight.Text = "";
            textBoxWeight.Text = "";
            Resultlabel.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void SaveToFile(double bmi, string category, string advice)     // دالة لحفظ النتيجة في ملف خارجي

        {
            try
            {
                using (StreamWriter writer = new StreamWriter("bmi_results.txt", true))
                {
                    writer.WriteLine($"BMI: {bmi}, Category: {category}, Advice: {advice}, Date: {DateTime.Now}");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while saving the file: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
