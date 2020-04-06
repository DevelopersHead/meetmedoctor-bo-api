using System;
using System.ComponentModel.DataAnnotations;
using mmd.bo.domain.intf;

namespace mmd.bo.domain.entity
{
    public class MenuItem:IEntity
    {
        //[Key]
        public Guid Id {get;set;}
        [MaxLength(25)]        
        public string Title{get;set;}
        public string Url{get;set;}

        public string StyleClass{get;set;}
    }
}