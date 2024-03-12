public class DoorMachine
{
    enum State
    { Terkunci, Terbuka };

    public static void Main()
    {
        State state = State.Terkunci;
        string[] screenName = { "Terkunci", "Terbuka" };
        while (true)
        {
            Console.WriteLine("Pintu sekarang: " + screenName[(int)state]);
            Console.WriteLine("Masukkan Perintah : ");

            string perintah = Console.ReadLine();
            switch (state)
            {

                case State.Terkunci:
                    if (perintah == "buka")
                    {
                        state = State.Terbuka;
                    }
                    break;
                case State.Terbuka:
                    if (perintah == "tutup")
                    {
                        state = State.Terkunci;
                    }
                    break;
            }
        }
    }
}
