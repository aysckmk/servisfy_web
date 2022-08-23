namespace ServisFy.Models.Auth
{
    public class RegisterDto
    {
        public int k_id { get; set; }
        public string k_adi { get; set; }
        public string k_soyadi { get; set; }
        public string passwordHash { get; set; }
        public string k_mail { get; set; }
        public string k_tc { get; set; }
    }
}
