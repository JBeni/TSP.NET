using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using LibraryEntityFramework.Context;

namespace LibraryEntityFramework.Repository
{
    public class ReviewRepository
    {
        public List<REVIEW> GetAllReviews()
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.REVIEWs.ToList();
            }
        }

        public List<REVIEW> GetReviewById(int reviewId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.REVIEWs.Where(t => t.ReviewId == reviewId).ToList();
            }
        }

        public REVIEW InsertReview(REVIEW review)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.REVIEWs.Add(review);
                context.SaveChanges();
                return review;
            }
        }

        public REVIEW UpdateReview(REVIEW review)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.REVIEWs.AddOrUpdate(review);
                context.SaveChanges();
                return review;
            }
        }

        public void DeleteReview(REVIEW review)
        {
            try
            {
                using (var context = new ModelDatabaseFirst())
                {
                    context.REVIEWs.Remove(review);
                    context.SaveChanges();
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
