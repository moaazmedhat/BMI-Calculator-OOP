using System;

namespace BMI_Calculator
{
    // كلاس عام ممكن نرث منه علشان نستخدم مبدأ الوراثة
    public class Calculator
    {
        // دالة افتراضية مش بتعمل حاجة هنا، هنعمل override ليها في الكلاس اللي بعده
        public virtual double Calculate(double value1, double value2)
        {
            return 0;
        }
    }

    // كلاس لحساب ال BMI, وبيورث من Calculator
    public class BMICalculator : Calculator
    {
        public double Height { get; private set; } // الطول
        public double Weight { get; private set; } // الوزن
        public double BMIValue { get; private set; } //القيمة النتاجة من الحساب
        public BMICalculator(double height, double weight)   // الـ constructor بيتنفذ لما نعمل object جديد وبيحط القيم الأولية

        {
            SetHeight(height);  // بنستخدم الدوال بدل ما نعدل على المتغيرات على طول
            SetWeight(weight);
            CalculateBMI();
        }

        public void SetHeight(double height)     // دالة لضبط الطول والتأكد إنه موجب

        {
            if (height <= 0)
                throw new ArgumentException("Height must be greater than zero.");
            Height = height;
            CalculateBMI(); // نحدث النتيجة كل مرة نغير فيها الطول
        }

        public void SetWeight(double weight)     // نفس الكلام مع الوزن

        {
            if (weight <= 0)
                throw new ArgumentException("Weight must be greater than zero");
            Weight = weight;
            CalculateBMI();
        }

        private void CalculateBMI()     // دالة داخلية بتحسب قيمة الـ BMI

        {
            if (Height > 0 && Weight > 0)
                BMIValue = Weight / (Height * Height);
            else
                BMIValue = 0;
        }

        public override double Calculate(double height, double weight)     // بنعمل override للدالة بتاعة الأب (Calculator)

        {
            return weight / (height * height);
        }
    }

    // enumeration لتصنيف الحالة الصحية على حسب قيمة الـ BMI
    public enum BMICategory
    {
        Underweight, //نحافة
        Normal,      //طبيعي
        Overweight,  //زيادة وزن
        Obese        //سمنة
    }

    // كلاس لتصنيف BMI وتقديم نصائح
    public static class BMIClassifier
    {
        public static BMICategory ClassifyBMI(double bmi)     // بيحدد نوع الحالة على حسب الرقم
        {
            if (bmi < 18.5)
                return BMICategory.Underweight;
            else if (bmi < 25)
                return BMICategory.Normal;
            else if (bmi < 30)
                return BMICategory.Overweight;
            else
                return BMICategory.Obese;
        }

        public static string GetCategoryDescription(BMICategory category) // وصف لكل حالة
        {
            switch (category)
            {
                case BMICategory.Underweight:
                    return "Underweight";
                case BMICategory.Normal:
                    return "Normal Weight";
                case BMICategory.Overweight:
                    return "Overweight";
                case BMICategory.Obese:
                    return "Obese";
                default:
                    return "Unknown";
            }
        }

        public static string GetAdvice(BMICategory category)     // بيرجع نصيحة لكل حالة
        {
            switch (category)
            {
                case BMICategory.Underweight:
                    return "Increase your calories by eating nuts and dairy products.";
                case BMICategory.Normal:
                    return "Maintain your current diet.";
                case BMICategory.Overweight:
                    return "Reduce calories and increase physical activity.";
                case BMICategory.Obese:
                    return "Consult a nutritionist to develop a suitable diet.";
                default:
                    return "";
            }
        }
    }
}
