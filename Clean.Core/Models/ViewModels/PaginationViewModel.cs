namespace Clean.Core.Models.ViewModels
{
    public class PaginationViewModel
    {
        public string Url { get; set; }
        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int PageCount => (int)((double)TotalItems / (double)PageSize);
        public int PageSize { get; set; }
        public int PageNumbersEitherSide { get; set; }
        public int PageNumberStart => PageNumber - PageNumbersEitherSide > 0 
            ? PageNumber - PageNumbersEitherSide
            : 1;

        public bool ShowFirst => PageNumberStart > 3;

        public int PageNumberEnd => PageNumber + PageNumbersEitherSide <= PageCount
      ? PageNumber + PageNumbersEitherSide
      : PageCount;
    }
}
