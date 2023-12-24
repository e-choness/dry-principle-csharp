using DryFrameworkLibrary.Interfaces;

namespace DryFrameworkLibrary.Services
{
    public class ProductProcessor
    {
        public string GenerateProductId(IProduct product)
        {
            var partialTitle = GetPartialTitle(product.Title, 3);
            var partialSubtitle = GetPartialTitle(product.Subtitle, 3);
            var id = partialTitle + partialSubtitle + product.TransactionDate.Date;
            product.Id = id;
        
            return id;
        }

        private string GetPartialTitle(string title, int length)
        {
            var partialTitle = title;
        
            if (title.Length == length)
            {
                return partialTitle.ToUpper();
            }
        
            if (title.Length > length)
            {
                partialTitle = title.Substring(0, length);
            }
            else
            {
                partialTitle += new string('0', length - title.Length);
            }

            return partialTitle.ToUpper();
        }
    }
}