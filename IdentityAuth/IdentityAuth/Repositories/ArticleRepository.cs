using IdentityAuth.Authentication;
using IdentityAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace IdentityAuth.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private ApplicationDbContext _context;
        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SaveArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        public IEnumerable<Article> GetAllArticle()
        {
            return  _context.Articles.AsEnumerable();
        }

        public Article GetArticle(int id)
        {
            return _context.Articles.SingleOrDefault(s => s.id == id);
        }

        public Article GetArticleByAuthor(string authorid)
        {
            return _context.Articles.SingleOrDefault(s => s.appUserId == authorid);
        }
        public void DeleteArticle(int id)
        {
            var article = _context.Articles.SingleOrDefault(s => s.id == id);
            _context.Remove(article);
            _context.SaveChanges();
        }
        public void UpdateArticle(Article article)
        {
            _context.Articles.Update(article);
            _context.SaveChanges();
        }
    }
}
