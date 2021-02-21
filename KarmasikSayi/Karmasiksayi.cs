namespace KarmasikSayi
{
    public class Karmasiksayi
    {
        private double mGercek;
        private double mSanal;
        public double gercek{
            get{return mGercek;}
            set{mGercek = value;}
        }
        public double sanal{
            get{return mSanal;}
            set{mSanal = value;}
        }
        public double Karmasiksayi(double x,double y){
            mGercek = x;
            mSanal = y;
        }
        public double Karmasiksayi(Karmasiksayi k){
            mGercek = k.mGercek;
            mSanal = k.mSanal;
        }
        public void yaz(){
            if(mSanal>0){
                Console.Writeline("{0}i+{1}j",mGercek,mSanal);
            }
            else{
                Console.Writeline("{0}i+{1}j",mGercek,mSanal);
            }
        }
        public static Karmasiksayi operator+(Karmasiksayi a,Karmasiksayi b){
                double gt = a.mGercek+b.mGercek;
                double st = a.mSanal-b.mGercek;
                return new Karmasiksayi(gt,st);
            }
            public static implicit operator double(Karmasiksayi x){
                double reel = x;
                return x;
            }
            
    }
}