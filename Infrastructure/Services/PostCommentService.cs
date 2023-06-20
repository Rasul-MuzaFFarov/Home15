
using Domain.Dtos.PostComments;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PostCommentService
{
    private readonly DataContext _context;

    public PostCommentService(DataContext context)
    {
        _context = context;
    }

    public PostCommentBase AddPostComment(PostCommentBase postComment)
    {
        _context.PostComments.Add(new PostComment()
        {
            Id = postComment.Id,
            PostId = postComment.PostId,
            CommenterId = postComment.CommenterId,
            Comment=postComment.Comment,
            DateCommented=postComment.DateCommented

        });
        _context.SaveChanges();
        return postComment;
    }
    

    public PostCommentBase UpdatePostComment(PostCommentBase postComment)
    {
        var find = _context.PostComments.Find(postComment.Id);
        if (find != null)
        {
            find.Id = postComment.Id;
            find.PostId = postComment.PostId;
            find.CommenterId = postComment.CommenterId;
            find.Comment = postComment.Comment;
            find.DateCommented = postComment.DateCommented;
            _context.SaveChanges();
        }
        return postComment;
    }

    public bool DeletePostComment(int id)
    {
        var find = _context.Categories.Find(id);
        if (find != null)
        {
            _context.Categories.Remove(find);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public PostCommentBase GetPostCommentById(int id)
        {
            var find = _context.PostComments.Find(id);
            if (find == null) return new PostCommentBase();
            return new PostCommentBase()
            {
                Id = find.Id,
                PostId = find.PostId ,
                CommenterId = find.CommenterId ,
                Comment = find.Comment,
                DateCommented = find.DateCommented 

                
            };    
        }

    

    public List<PostCommentBase> PostComments()
    {
        return _context.PostComments.Select(c => new PostCommentBase()
        {
            Id = c.Id,
            PostId = c.PostId,
            CommenterId = c.CommenterId,
            Comment = c.Comment,
            DateCommented = c.DateCommented
        }).ToList();
    }
}