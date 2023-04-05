int Stepen(int Anumber, int Bnumber){
  int result = 1;
  for(int i=1; i <= Bnumber; i++){
    result = result * Anumber;
  }
    return result;
}
  Console.Write("Число A: ");
  int Anumber = int.Parse(Console.ReadLine());
  Console.Write("Число B: ");
  int Bnumber = int.Parse(Console.ReadLine());
  int stepen = Stepen(Anumber, Bnumber);
  Console.WriteLine("Равно: " + stepen);