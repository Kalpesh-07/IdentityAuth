using IdentityAuth.Models;
using System.Collections.Generic;

namespace IdentityAuth.Repositories
{
    public interface IArticleRepository
    {
        void SaveArticle(Article article);
        IEnumerable<Article> GetAllArticle();
        Article GetArticle(int id);
        void DeleteArticle(int id);
        void UpdateArticle(Article article);
    }
}
