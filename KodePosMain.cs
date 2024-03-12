KodePos objKodePos = new KodePos();
Console.WriteLine("List Kelurahan: ");
foreach (KodePos.Kelurahan kelurahan in Enum.GetValues(typeof(KodePos.Kelurahan)))
{
    int kodePos = objKodePos.getKodePos(kelurahan);
    Console.WriteLine(kelurahan + "   \t " + kodePos);
}