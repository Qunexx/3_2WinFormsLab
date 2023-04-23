namespace WinFormsApp2;

public class MyCalc
{
    private double _a = 0.0;
    private double _b = 0.0;

    public double a
    {
        get { return _a; }
        set
        {
            if (value == 0)
                throw new Exception("Нулевое значение a недопустимо!");
            else
                _a = value;
        }
    }

    public double b
    {
        get { return _b; }
        set
        {
            if (value == 0)
                throw new Exception("Нулевое значение b недопустимо!");
            else
                _b = value;
        }
    }

    public double calc()
    {
        return ((a + b) / a + (a - b) / b);
    }


    public class MyCalc1 : MyCalc
    {
        //Сумма (i+1)/(a+d)/a + i*(a-d)/d для i=0,d
        private int i;

        private int _d;

        public int d
        {
            get { return _d;}
            set
            {
                if (value == 0)
                    throw new Exception("Нулевое значение d недопустимо!");
                else
                {
                    _d = value;
                }
            }
        }


        public double calc1()
        {
           
           double step = 0;
           double S = 0;
           for (i = 0; i < d; i++)
           {
               step = (i + 1) / (a + d) / a + i * (a - d) / d;
               S += step;

           }

           return S;
        }
        
    }
                                        




}