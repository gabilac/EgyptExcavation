using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EgyptExcavation.Models;

#nullable disable

namespace EgyptExcavation.Models
{
    public class BurialFilterLogic
    {
        private EgyptDbContext context;

        public BurialFilterLogic()
        {
            //context = new EgyptDbContext();
        }

        public IQueryable<Burial> GetBurials(BurialFilterModel filterModel)
        {
            var result = context.Burials.AsQueryable();

            if (filterModel != null)
            {
                //  filter on BurialCompositeId
                if (!string.IsNullOrEmpty(filterModel.BurialCompositeId))
                    result = result.Where(b => b.BurialCompositeId.Contains(filterModel.BurialCompositeId));

                //  filter on YearFound
                if (filterModel.YearFoundFrom.HasValue)
                    result = result.Where(b => b.YearFound >= filterModel.YearFoundFrom);
                if (filterModel.YearFoundTo.HasValue)
                    result = result.Where(b => b.YearFound <= filterModel.YearFoundTo);

                //  filter on BodyColGender
                if (filterModel.BodyColGender != null)
                    result = result.Where(b => b.BodyColGender == filterModel.BodyColGender);

                //  filter on EstimatedAge
                if (filterModel.EstimatedAgeFrom.HasValue)
                    result = result.Where(b => b.EstimatedAge >= filterModel.EstimatedAgeFrom);
                if (filterModel.EstimatedAgeTo.HasValue)
                    result = result.Where(b => b.EstimatedAge <= filterModel.EstimatedAgeTo);

                //  filter on HairColor
                if (filterModel.HairColor != null)
                    result = result.Where(b => b.HairColor == filterModel.HairColor);

                //  filter on Depth
                if (filterModel.DepthFrom.HasValue)
                    result = result.Where(b => b.Depth >= filterModel.DepthFrom);
                if (filterModel.DepthTo.HasValue)
                    result = result.Where(b => b.Depth <= filterModel.DepthTo);

                //  filter on LengthofRemains
                if (filterModel.LengthofRemainsFrom.HasValue)
                    result = result.Where(b => b.LengthofRemains >= filterModel.LengthofRemainsFrom);
                if (filterModel.LengthofRemainsTo.HasValue)
                    result = result.Where(b => b.LengthofRemains <= filterModel.LengthofRemainsTo);

                //  filter on HeadDirection
                if (filterModel.HeadDirection != null)
                    result = result.Where(b => b.HeadDirection == filterModel.HeadDirection);

                //  filter on HairTaken
                if (filterModel.HairTaken != null)
                    result = result.Where(b => b.HairTaken == filterModel.HairTaken);

                //  filter on SoftTissueTaken
                if (filterModel.SoftTissueTaken != null)
                    result = result.Where(b => b.SoftTissueTaken == filterModel.SoftTissueTaken);

                //  filter on BoneTaken
                if (filterModel.BoneTaken != null)
                    result = result.Where(b => b.BoneTaken == filterModel.BoneTaken);

                //  filter on ToothTaken
                if (filterModel.ToothTaken != null)
                    result = result.Where(b => b.ToothTaken == filterModel.ToothTaken);

                //  filter on TextileTaken
                if (filterModel.HeadDirection != null)
                    result = result.Where(b => b.TextileTaken == filterModel.TextileTaken);

                //  filter on ArtifactFound
                if (filterModel.ArtifactFound != null)
                    result = result.Where(b => b.ArtifactFound == filterModel.ArtifactFound);

                //  filter on Notes
                if (!string.IsNullOrEmpty(filterModel.Notes))
                    result = result.Where(b => b.Notes.Contains(filterModel.Notes));
            }

            return result;
        }
    }
}

