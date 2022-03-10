using Entities;

namespace ParticipantPanel.ViewModels
{
    public class HomeVM
    {
        public List<Itweb> Itweb { get; set; }
        public List<int> ages { get; set; }
        public List<int> ageCounts { get; set; }
        public int itWebCount { get; set; }
        public int humenCount { get; set; }
        public List<Human> humen { get; set; }
        public int lpcount { get; set; }
        public List<Logistic> logistics { get; set; }
        public int afcount { get; set; }
        public List<AfDep> afDeps { get; set; }
    }
}
