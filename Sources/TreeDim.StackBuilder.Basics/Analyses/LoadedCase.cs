﻿using System.Collections.Generic;

namespace treeDiM.StackBuilder.Basics
{
    public class LoadedCase : PackableLoaded
    {
        internal LoadedCase(AnalysisHomo analysis)
            : base(analysis)
        {
        }
        public override GlobID ID
        {
            get
            {
                return new GlobID(
                    ParentAnalysis.ID.IGuid,
                    $"{Properties.Resources.ID_NAMECASE}({ParentAnalysis.Name})",
                    ParentAnalysis.Description
                    );
            }
        }
        public Packable Container => Analysis.CaseProperties;

        #region Override PackableBrick
        public override bool IsCase => true;
        public override double Length => Analysis.CaseProperties.Length;
        public override double Width => Analysis.CaseProperties.Width;
        public override double Height => Analysis.CaseProperties.Height;
        #endregion
        public override bool InnerContent(ref List<Pair<Packable, int>> listInnerPackables)
        {
            if (null == listInnerPackables) listInnerPackables = new List<Pair<Packable, int>>();
            listInnerPackables.Add(new Pair<Packable, int>(ParentAnalysis.Content, ParentSolution.ItemCount));
            return true;
        }
        public override bool InnerAnalysis(ref AnalysisHomo analysis)
        {
            analysis = Analysis;
            return true;
        }

        #region Non-Public Members
        private AnalysisPackableCase Analysis => ParentAnalysis as AnalysisPackableCase;
        protected override string TypeName => Properties.Resources.ID_LOADEDCASE;
        #endregion
    }
}
