﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Storage")>  _
Partial Public Class StorageItemDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertItem(instance As Item)
    End Sub
  Partial Private Sub UpdateItem(instance As Item)
    End Sub
  Partial Private Sub DeleteItem(instance As Item)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Agile_Assignment.My.MySettings.Default.StorageConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Items() As System.Data.Linq.Table(Of Item)
		Get
			Return Me.GetTable(Of Item)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Items")>  _
Partial Public Class Item
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ItemID As String
	
	Private _ItemName As String
	
	Private _ItemPrice As System.Nullable(Of Integer)
	
	Private _ItemDescription As String
	
	Private _ItemQuantity As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnItemIDChanging(value As String)
    End Sub
    Partial Private Sub OnItemIDChanged()
    End Sub
    Partial Private Sub OnItemNameChanging(value As String)
    End Sub
    Partial Private Sub OnItemNameChanged()
    End Sub
    Partial Private Sub OnItemPriceChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnItemPriceChanged()
    End Sub
    Partial Private Sub OnItemDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnItemDescriptionChanged()
    End Sub
    Partial Private Sub OnItemQuantityChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnItemQuantityChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ItemID", DbType:="VarChar(10) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property ItemID() As String
		Get
			Return Me._ItemID
		End Get
		Set
			If (String.Equals(Me._ItemID, value) = false) Then
				Me.OnItemIDChanging(value)
				Me.SendPropertyChanging
				Me._ItemID = value
				Me.SendPropertyChanged("ItemID")
				Me.OnItemIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ItemName", DbType:="VarChar(50)")>  _
	Public Property ItemName() As String
		Get
			Return Me._ItemName
		End Get
		Set
			If (String.Equals(Me._ItemName, value) = false) Then
				Me.OnItemNameChanging(value)
				Me.SendPropertyChanging
				Me._ItemName = value
				Me.SendPropertyChanged("ItemName")
				Me.OnItemNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ItemPrice", DbType:="Int")>  _
	Public Property ItemPrice() As System.Nullable(Of Integer)
		Get
			Return Me._ItemPrice
		End Get
		Set
			If (Me._ItemPrice.Equals(value) = false) Then
				Me.OnItemPriceChanging(value)
				Me.SendPropertyChanging
				Me._ItemPrice = value
				Me.SendPropertyChanged("ItemPrice")
				Me.OnItemPriceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ItemDescription", DbType:="VarChar(100)")>  _
	Public Property ItemDescription() As String
		Get
			Return Me._ItemDescription
		End Get
		Set
			If (String.Equals(Me._ItemDescription, value) = false) Then
				Me.OnItemDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._ItemDescription = value
				Me.SendPropertyChanged("ItemDescription")
				Me.OnItemDescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ItemQuantity", DbType:="Int")>  _
	Public Property ItemQuantity() As System.Nullable(Of Integer)
		Get
			Return Me._ItemQuantity
		End Get
		Set
			If (Me._ItemQuantity.Equals(value) = false) Then
				Me.OnItemQuantityChanging(value)
				Me.SendPropertyChanging
				Me._ItemQuantity = value
				Me.SendPropertyChanged("ItemQuantity")
				Me.OnItemQuantityChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
