namespace Ajax.Models.UserDTO
{
    public class UserDTO
    {
        public string? Name { get; set; }
        public int? Age{ get; set; }
        public string? Email{ get; set; }
        public IFormFile? Avatar{ get; set; } //讓檔案類型可以傳送   ,Avatar是File的name 

    }
}
