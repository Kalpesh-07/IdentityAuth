using IdentityAuth.Authentication;
using IdentityAuth.Enums;
using IdentityAuth.Models;
using IdentityAuth.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleRepository articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        [HttpGet("GetAllArticle", Name = "GetAllArticle")]
        public async Task<ResponseModel> GetAllArticle()
        {
            IEnumerable<Article> model =  articleRepository.GetAllArticle();
            return await Task.FromResult(new ResponseModel(ResponseCode.OK, "Get All Articles", model));
        }

        [HttpGet("GetArticleById/{id}", Name = "GetArticleById")]
        public async Task<ResponseModel> GetArticleById(int id)
        {
            Article model = articleRepository.GetArticle(id);
            return await Task.FromResult(new ResponseModel(ResponseCode.OK, "Get All Articles", model));
        }

        [HttpGet("GetArticleByAuthorId/{AuthorId}", Name = "GetArticleByAuthorId")]
        public async Task<ResponseModel> GetArticleByAuthorId(int AuthorId)
        {
            Article model = articleRepository.GetArticle(AuthorId);
            return await Task.FromResult(new ResponseModel(ResponseCode.OK, "Get All Articles", model));
        }

        [HttpPost("AddUpdateArticle")]
        public async Task<ResponseModel> AddUpdateArticle([FromBody] Article article)
        {
            article.createdDate = new DateTime();
            article.modifiedDate = new DateTime();
            if(article.id == 0)
            {
                articleRepository.SaveArticle(article);
            }
            else
            {
                articleRepository.UpdateArticle(article);
            }
            return await Task.FromResult(new ResponseModel(ResponseCode.OK, "Article has been Created", article));
        }

        [HttpDelete("{id}")]
        public ActionResult<Article> DeleteArticle(int id)
        {
            articleRepository.DeleteArticle(id);
            return Ok();
        }
    }
}
