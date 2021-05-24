﻿namespace NineChronicles.DataProvider.GraphQL.Types
{
    using global::GraphQL.Types;
    using NineChronicles.DataProvider.Store.Models;

    public class StageRankingType : ObjectGraphType<StageRankingModel>
    {
        public StageRankingType()
        {
            Field(x => x.Ranking);
            Field(x => x.ClearedStageId);
            Field(x => x.AvatarAddress);
            Field(x => x.Name);

            Name = "StageRanking";
        }
    }
}
