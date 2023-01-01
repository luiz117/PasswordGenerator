namespace Password
{
    public static class PassGen
    {
        private static Random random = new Random();
        public static string GeneratePass(int Size)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()Ç[](){}-+/,.~^º£¢Ç|\\";

            string passwordInCaps = new string(Enumerable.Repeat(chars, Size).Select(s => s[random.Next(s.Length)]).ToArray()).ToLower();

            var scrambleCaps = passwordInCaps.Select(x => random.Next() % 2 == 0 ? (char.IsUpper(x) ? x.ToString().ToLower().First() : x.ToString().ToUpper().First()) : x);
            var resultScrambleCaps = new string(scrambleCaps.ToArray());

            return resultScrambleCaps;            
        }
    }
}
