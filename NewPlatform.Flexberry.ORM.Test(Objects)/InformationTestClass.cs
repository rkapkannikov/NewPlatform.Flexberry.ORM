﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// InformationTestClass.
    /// </summary>
    // *** Start programmer edit section *** (InformationTestClass CustomAttributes)

    // *** End programmer edit section *** (InformationTestClass CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("InformationTestClassE", new string[] {
            "StringPropertyForInformationTestClass",
            "PublicStringProperty"})]
    public class InformationTestClass : ICSSoft.STORMNET.DataObject
    {
        
        private string fPublicStringProperty;
        
        private string fStringPropertyForInformationTestClass;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableInt fIntPropertyForInformationTestClass;
        
        private bool fBoolPropertyForInformationTestClass;
        
        // *** Start programmer edit section *** (InformationTestClass CustomMembers)

        // *** End programmer edit section *** (InformationTestClass CustomMembers)

        
        /// <summary>
        /// PublicStringProperty.
        /// </summary>
        // *** Start programmer edit section *** (InformationTestClass.PublicStringProperty CustomAttributes)

        // *** End programmer edit section *** (InformationTestClass.PublicStringProperty CustomAttributes)
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "TestDataServiceExpression")]
        public virtual string PublicStringProperty
        {
            get
            {
                // *** Start programmer edit section *** (InformationTestClass.PublicStringProperty Get start)

                // *** End programmer edit section *** (InformationTestClass.PublicStringProperty Get start)
                string result = this.fPublicStringProperty;
                // *** Start programmer edit section *** (InformationTestClass.PublicStringProperty Get end)

                // *** End programmer edit section *** (InformationTestClass.PublicStringProperty Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InformationTestClass.PublicStringProperty Set start)

                // *** End programmer edit section *** (InformationTestClass.PublicStringProperty Set start)
                this.fPublicStringProperty = value;
                // *** Start programmer edit section *** (InformationTestClass.PublicStringProperty Set end)

                // *** End programmer edit section *** (InformationTestClass.PublicStringProperty Set end)
            }
        }
        
        /// <summary>
        /// StringPropertyForInformationTestClass.
        /// </summary>
        // *** Start programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass CustomAttributes)

        // *** End programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass CustomAttributes)
        [PropertyStorage("StringPropertyForInfTestClass")]
        [StrLen(255)]
        public virtual string StringPropertyForInformationTestClass
        {
            get
            {
                // *** Start programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Get start)

                // *** End programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Get start)
                string result = this.fStringPropertyForInformationTestClass;
                // *** Start programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Get end)

                // *** End programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Set start)

                // *** End programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Set start)
                this.fStringPropertyForInformationTestClass = value;
                // *** Start programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Set end)

                // *** End programmer edit section *** (InformationTestClass.StringPropertyForInformationTestClass Set end)
            }
        }
        
        /// <summary>
        /// IntPropertyForInformationTestClass.
        /// </summary>
        // *** Start programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass CustomAttributes)

        // *** End programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass CustomAttributes)
        [PropertyStorage("IntPropertyForInfTestClass")]
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableInt IntPropertyForInformationTestClass
        {
            get
            {
                // *** Start programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Get start)

                // *** End programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableInt result = this.fIntPropertyForInformationTestClass;
                // *** Start programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Get end)

                // *** End programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Set start)

                // *** End programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Set start)
                this.fIntPropertyForInformationTestClass = value;
                // *** Start programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Set end)

                // *** End programmer edit section *** (InformationTestClass.IntPropertyForInformationTestClass Set end)
            }
        }
        
        /// <summary>
        /// BoolPropertyForInformationTestClass.
        /// </summary>
        // *** Start programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass CustomAttributes)

        // *** End programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass CustomAttributes)
        [PropertyStorage("BoolPropertyForInfTestClass")]
        public virtual bool BoolPropertyForInformationTestClass
        {
            get
            {
                // *** Start programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Get start)

                // *** End programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Get start)
                bool result = this.fBoolPropertyForInformationTestClass;
                // *** Start programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Get end)

                // *** End programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Set start)

                // *** End programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Set start)
                this.fBoolPropertyForInformationTestClass = value;
                // *** Start programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Set end)

                // *** End programmer edit section *** (InformationTestClass.BoolPropertyForInformationTestClass Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "InformationTestClassE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View InformationTestClassE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("InformationTestClassE", typeof(NewPlatform.Flexberry.ORM.Tests.InformationTestClass));
                }
            }
        }
    }
}
