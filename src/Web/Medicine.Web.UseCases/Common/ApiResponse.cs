namespace Medicine.Web.UseCases.Common
{
    public record ApiResponse<T>(T Message);

    public record ApiResponse<T1, T2>((T1 Item1, T2 Item2) Message)
    {
        public ApiResponse() : this((default, default)) { }
    }

}
