﻿Public Interface IFlowsheet

    Enum MessageType
        Information
        Warning
        GeneralError
        Tip
        Other
    End Enum

    ReadOnly Property Reactions As Dictionary(Of String, IReaction)

    ReadOnly Property ReactionSets As Dictionary(Of String, IReactionSet)

    ReadOnly Property SimulationObjects As Dictionary(Of String, ISimulationObject)

    ReadOnly Property GraphicObjects As Dictionary(Of String, IGraphicObject)

    ReadOnly Property Settings As Dictionary(Of String, Object)

    Sub ShowMessage(ByVal text As String, ByVal mtype As MessageType)

    Sub ShowDebugInfo(ByVal text As String, ByVal level As Integer)

    Sub CheckStatus()

    Function GetTranslatedString(text As String, locale As String) As String

    ReadOnly Property FlowsheetOptions As IFlowsheetOptions

End Interface