public class Program{
    static int C (int K,int A,int S){
        if (1<K && K<=1000){
            Console.WriteLine($"{A} {S}");
            return K++;
        }
        return K;
    }
    static void Main(string[] args){
        int N,K;
        Console.Write("จำนวนผู้เข้าแข่งขัน : ");
        N = int.Parse(Console.ReadLine());
        Console.Write("จำนวนที่กรรมการรับได้ : ");
        K = int.Parse(Console.ReadLine());

        int K1 = K;
        int K2 = K;

        for(int adder = 1; adder <= N; adder++)
        {
            Console.Write("เพศ : ");
            int S = int.Parse(Console.ReadLine());
            Console.Write("คะแนนของกรรมการ(ช) : ");
            int S1 = int.Parse(Console.ReadLine());
            Console.Write("คะแนนของกรรมการ(ญ) : ");
            int S2 = int.Parse(Console.ReadLine());

            if (S1 >= 9 || S2 >= 9){
                if (S1 >= 9 && S2 >= 9){
                    if (S == 1){
                        //Console.WriteLine("T1");
                        S1 = C(K1,adder,1);
                    }else {
                        //Console.WriteLine("T2");
                        S2 = C(K2,adder,2);
                    }
                }
                else if (S1 > S2){
                    S1 = C(K1,adder,1);
                } else if (S1 < S2) {
                    S2 = C(K2,adder,2);
                }
            }

        }


    }
}