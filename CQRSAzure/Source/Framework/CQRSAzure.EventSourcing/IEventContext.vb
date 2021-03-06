﻿''' <summary>
''' Additional context information about an event 
''' </summary>
''' <remarks>
''' Different domains often require additional context information about events that occured
''' By having a seperate context interface you can segregate these from the actual event itself
''' </remarks>
Public Interface IEventContext
    Inherits IEventInstance

    ''' <summary>
    ''' Which user caused the event to occur
    ''' </summary>
    ''' <remarks>
    ''' This can be empty in the case of timer or state triggered events
    ''' </remarks>
    ReadOnly Property Who As String

    ''' <summary>
    ''' The time at which this event occured
    ''' </summary>
    ''' <remarks>
    ''' This should be stored as UTC or have timezone information
    ''' </remarks>
    ReadOnly Property Timestamp As Date

    ''' <summary>
    ''' The source from whence this event originated
    ''' </summary>
    ReadOnly Property Source As String

    ''' <summary>
    ''' Sequence for holding events in a queue or queue-like storage
    ''' </summary>
    ReadOnly Property SequenceNumber As Long

    ''' <summary>
    ''' Any additional comments attached to the event for audit purposes for example
    ''' </summary>
    ReadOnly Property Commentary As String


End Interface

Public Interface IEventContext(Of TAggregationKey)
    Inherits IEventContext
    Inherits IEventInstance(Of TAggregationKey)


End Interface