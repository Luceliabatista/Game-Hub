namespace GameHub.Entities
{
    public class DataRegister
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Cpf { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public int Pontuacao { get; set; }

        public void Save()
        {
            List<DataRegister> Query = new();
            var players = SerializeDeserialize.Read<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json");
            players.ForEach(player =>
            {
               if (this.Cpf == player.Cpf) {
                    Query.Add(this);
               } else {
                    Query.Add(player);
                }
            });

            SerializeDeserialize.SaveAll<DataRegister>(@"C:\Users\lucel\SharpCoders\GameHub\GameHub\data\jogadores.json", Query);
        }
    }
}
