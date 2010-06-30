﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'tblTestProduct' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITestProduct 
	{
		/// <summary>			
		/// ProductID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblTestProduct"</remarks>
		System.Int32 ProductId { get; set; }
				
		
		
		/// <summary>
		/// ProductTypeID : 
		/// </summary>
		System.Int32?  ProductTypeId  { get; set; }
		
		/// <summary>
		/// DownloadID : 
		/// </summary>
		System.Int32?  DownloadId  { get; set; }
		
		/// <summary>
		/// ManufacturerID : 
		/// </summary>
		System.Int32?  ManufacturerId  { get; set; }
		
		/// <summary>
		/// BrandName : 
		/// </summary>
		System.String  BrandName  { get; set; }
		
		/// <summary>
		/// ProductName : 
		/// </summary>
		System.String  ProductName  { get; set; }
		
		/// <summary>
		/// ProductCode : 
		/// </summary>
		System.String  ProductCode  { get; set; }
		
		/// <summary>
		/// UniqueIdentifier : 
		/// </summary>
		System.String  UniqueIdentifier  { get; set; }
		
		/// <summary>
		/// TypeName : 
		/// </summary>
		System.String  TypeName  { get; set; }
		
		/// <summary>
		/// ModelName : 
		/// </summary>
		System.String  ModelName  { get; set; }
		
		/// <summary>
		/// DisplayName : 
		/// </summary>
		System.String  DisplayName  { get; set; }
		
		/// <summary>
		/// ProductLink : 
		/// </summary>
		System.String  ProductLink  { get; set; }
		
		/// <summary>
		/// ConnectorCode : 
		/// </summary>
		System.String  ConnectorCode  { get; set; }
		
		/// <summary>
		/// BaseID : 
		/// </summary>
		System.Int32?  BaseId  { get; set; }
		
		/// <summary>
		/// OrgProductID : 
		/// </summary>
		System.Int32?  OrgProductId  { get; set; }
		
		/// <summary>
		/// ImageFileType : 
		/// </summary>
		System.String  ImageFileType  { get; set; }
		
		/// <summary>
		/// FullImageFileType : 
		/// </summary>
		System.String  FullImageFileType  { get; set; }
		
		/// <summary>
		/// Status : 
		/// </summary>
		System.String  Status  { get; set; }
		
		/// <summary>
		/// AddedBy : 
		/// </summary>
		System.Int32?  AddedBy  { get; set; }
		
		/// <summary>
		/// AddedDate : 
		/// </summary>
		System.DateTime?  AddedDate  { get; set; }
		
		/// <summary>
		/// UpdatedBy : 
		/// </summary>
		System.Int32?  UpdatedBy  { get; set; }
		
		/// <summary>
		/// UpdatedDate : 
		/// </summary>
		System.DateTime?  UpdatedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

