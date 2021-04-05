namespace SGP.Domain
{
    public class Player
    {
        public string GameSessionId { get; set; }

        public GameSession GameSession { get; set; }

        public Actor Actor { get; set; }

        public IEnumerable<AttributeValue> Values { get; set; }
    }
}
