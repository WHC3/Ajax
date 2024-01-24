namespace Ajax.Models.UserDTO
{
    public class SearchDTO
    {
        //搜尋相關
        public string? Keyword { get; set; }
        public int? categoryId { get; set; } = 0; //預設0表示不根據分類標號進行搜尋


        //排序相關
        public string? sortBy { get; set; }
        public string? sortType { get; set; }= "asc"; //預設desc

        //分頁相關
        public int page { get; set; } = 1; //預設第一頁
        public int pageSize { get; set; } = 9;  //預設每頁9筆
    }
}
