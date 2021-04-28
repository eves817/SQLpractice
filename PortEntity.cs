namespace SQL5
{
    public class PortEntity
    {
         
        /// <summary>
        /// Country Name
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Port Name
        /// </summary>
        public string PortText { get; set; }

        public string PortValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Does the port support container shipping method only
        /// </summary>
        public bool IsContainerOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsParent { get; set; }

    
}
}