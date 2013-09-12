object Form1: TForm1
  Left = 0
  Top = 0
  Caption = #1044#1077#1084#1086#1085#1089#1090#1088#1072#1094#1080#1103' '#1088#1072#1073#1086#1090#1099' '#1089' Delphi'
  ClientHeight = 189
  ClientWidth = 355
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  DesignSize = (
    355
    189)
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 16
    Width = 56
    Height = 13
    Caption = #1055#1086#1083#1080#1085#1086#1084' 1:'
  end
  object Label2: TLabel
    Left = 8
    Top = 46
    Width = 56
    Height = 13
    Caption = #1055#1086#1083#1080#1085#1086#1084' 2:'
  end
  object Label3: TLabel
    Left = 10
    Top = 104
    Width = 61
    Height = 13
    Caption = #1057#1091#1084#1084#1072' 1 '#1080' 2:'
  end
  object Polynom1: TEdit
    Left = 88
    Top = 16
    Width = 257
    Height = 21
    Anchors = [akLeft, akTop, akRight]
    TabOrder = 0
    Text = '2x^2+3x+1'
    ExplicitWidth = 337
  end
  object Polynom2: TEdit
    Left = 88
    Top = 43
    Width = 257
    Height = 21
    Anchors = [akLeft, akTop, akRight]
    TabOrder = 1
    Text = '4x+5'
    ExplicitWidth = 337
  end
  object PolynomResult: TEdit
    Left = 90
    Top = 101
    Width = 257
    Height = 21
    Anchors = [akLeft, akTop, akRight]
    TabOrder = 2
  end
  object CalculateButton: TButton
    Left = 120
    Top = 70
    Width = 97
    Height = 25
    Caption = #1042#1099#1095#1080#1089#1083#1080#1090#1100'!'
    TabOrder = 3
    OnClick = CalculateButtonClick
  end
end
