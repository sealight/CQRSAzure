﻿Imports System.Configuration

''' <summary>
''' Maps an aggregation class to the event stream implementation
''' </summary>
Public Class CQRSAzureEventSourcingAggregateMapElement
    Inherits ConfigurationElement

    ''' <summary>
    ''' The domain-qualified name of the aggregate class that uses the given implementation 
    ''' for it's event stream backing store
    ''' </summary>
    ''' <remarks>
    ''' This must be unqiue within the CQRSAzureEventSourcingAggregateMapElementCollection
    ''' </remarks>
    <ConfigurationProperty(NameOf(AggregateDomainQualifiedName), IsKey:=True, IsRequired:=True)>
    Public Property AggregateDomainQualifiedName As String
        Get
            Return Me(NameOf(AggregateDomainQualifiedName))
        End Get
        Set(value As String)
            Me(NameOf(AggregateDomainQualifiedName)) = value
        End Set
    End Property

    ''' <summary>
    ''' The name of the implementation to use - this allows different configuration properties per event stream
    ''' </summary>
    ''' <remarks>
    ''' The name relates to the XXXXSettingsElement identified by the name
    ''' </remarks>
    <ConfigurationProperty(NameOf(ImplementationName), DefaultValue:="Default")>
    Public Property ImplementationName As String
        Get
            Return Me(NameOf(ImplementationName))
        End Get
        Set(value As String)
            Me(NameOf(ImplementationName)) = value
        End Set
    End Property



End Class
