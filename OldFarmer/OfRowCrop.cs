using static System.Collections.Specialized.BitVector32;

namespace AOGPlanterV2.OF
{
    public class OfRowCrop
    {
        #region Constructor and Vars
        public const string NotConnected = "nc";
        public const string Normal = "normal";
        private FormAOP mf { get; }
        //		private Dictionary<string, vec3> conditionLookup { get; set; }
        private Dictionary<int, SectionState> sectionState { get; set; }
        public OfRowCrop(FormAOP _f)
        {
            mf = _f;
            InitSkip();
            //			InitSectionState();
        }
        //where in the pgn is data
        public int[] rcRowStatus = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }; // 0 = normal, 1 = out, 2 = skip, 3 = double 4 = nc
        public int[] rcSkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] rcDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] rcArraySkips = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] rcArrayDoubles = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] rcPopulation = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] rcPopulationPercent = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] rcSingulationPercent = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int fertilizerWeight = 0;
        public byte fertilizerActualPosition = 0;
        public byte fertilizerSetPosition = 0;
        public byte fertilizerForcedPosition = 0;
        public int fbNumSections = 0;
        public float fbRowWidth = 0.0f;
        public float fbTargetSpeed = 0.0f;
        public float fbTargetPopulation = 0.0f;
        public float fbDoublesFactor = 0.0f;
        public int fbFeedbackCounter = 0;
        public bool fbIsMetric = false;
        public float sumSkipPercent = 1.3f;
        public float sumDoublePercent = .2f;
        public float sumSingulation = 98.5f;
        public float sumPopulation = 32000f;
        public DateTime timePrev;
        public DateTime timeDataReceived;
        public TimeSpan updateSkipDisplayInterval = TimeSpan.FromSeconds(Properties.Settings.Default.setPlanterArraySpeed);
        public int SkipDisplayInterval = 1;
        internal class SectionState
        {
            public string state { get; set; }
            public bool changed { get; set; }

            public void ChangeState(string state)
            {
                if (this.state != state)
                {
                    this.state = state;
                    changed = true;
                }
            }
            public string GetCurrentState() { return state; }
            public string GetState() { changed = false; return GetCurrentState(); }
            public bool HasStateChanged() { return changed; }
        }
        public void InitSectionState()
        {
            sectionState = new Dictionary<int, SectionState>();

            for (int j = 0; j < mf.tool.numOfSections + 1; j++)
                sectionState.Add(j, new SectionState() { state = NotConnected, changed = true });
        }

        private void InitSkip()
        {
            //	conditionLookup = new Dictionary<string, vec3>();
            //	conditionLookup.Add("skip", new vec3(255, 255, 0)); // yellow
            //	conditionLookup.Add("double", new vec3(200, 35, 200)); // purple
            //	conditionLookup.Add("out", new vec3(255, 0, 0));  // red
        }
        #endregion

    }
}
