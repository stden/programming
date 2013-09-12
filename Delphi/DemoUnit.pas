unit DemoUnit;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    Polynom1: TEdit;
    Polynom2: TEdit;
    PolynomResult: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    CalculateButton: TButton;
    procedure CalculateButtonClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

uses Math;

type
  TPolynom = array of double; { ������ - ��� ������� }

function StrToPolynom( S : string ):TPolynom;
var
  i: Integer;
  Coef, Power: Integer; { ����������� � ������� }
  M: string; { ����� }
  ReadPow : boolean; { ������ ������� }
begin
  { ������ (�������) ������ }
  { ��������: 2x^3-2x^2+4x+4 }
  { �������� ������� �� ������ �� +- � ����� ������ }
  S := trim(LowerCase(S)) + '$'; { $ - ��������� ���� ������ � ����� ������ }
  M := ''; { ������� ����� }
  Power := 0; { ������� }
  Coef := 1; { ����������� }
  { ���� � �������� ������ ������ ���, �� ������� ����� 0 }
  SetLength(Result, 1);
  Result[0] := 0;
  ReadPow := false;
  for i := 1  to Length(S) do begin
    case S[i] of
      '+', '-', '$': { ����� ��������, ��������� � ������ ��������, $ - ����� ������ }
        begin
          { ��������� ��� � ������� }
          if M<>'' then
            if ReadPow then
              Power := StrToInt(M)
            else
              Coef := StrToInt(M);
          { ���� ����. ������ ������� ��������,
            �� ����������� ������� �������� }
          if Power > Length(Result)-1 then
            SetLength(Result, Power + 1);
          Result[Power] := Coef;
          Power := 0;
          Coef := 1;
          ReadPow := false;
          M := S[i];
        end;
      'x': { �������� ����������� }
        begin
          if Power = 0 then
            Power := 1;
          { ���������� ����������� }
          Coef := StrToInt(M);
          M := '';
        end;
      '^': { ������ ������� }
        begin
          ReadPow := true;
        end;
      else
        M := M + S[i]; { ���������� ������� }
    end;
  end;
end;

{ �������� ��������� � 0 }
const eps = 1e-17;

function PolynomToStr( P : TPolynom ):string;
var
  I: Integer;
begin
  Result := '';
  for I := Length(P) downto 0 do
    if abs(P[i]) > eps then begin
      if (Length(Result) > 0) and (P[i] > 0) then
        Result := Result + '+';
      Result := Result + FloatToStr(P[i]);
      if i > 0 then
        Result := Result + 'x';
      if i > 1 then
        Result := Result + '^' + IntToStr(i);
    end;
end;

{ ����� ���� ��������� }
function SumPolynom( P1, P2 : TPolynom ):TPolynom;
var D,i : integer;
begin
  D := Max(Length(P1), Length(P2));
  SetLength(Result, D);
  for i := 0 to Min(Length(P1), Length(P2))-1 do
    Result[i] := P1[i] + P2[i];
  if Length(P1) > Length(P2) then begin
    for i := Length(P2) to Length(P1)-1 do
      Result[i] := P1[i];
  end else begin
    for i := Length(P1) to Length(P2)-1 do
      Result[i] := P2[i];
  end;
end;

procedure TForm1.CalculateButtonClick(Sender: TObject);
var P1, P2, PR : TPolynom;
begin
  { ��������� �� ���������� P1 � P2 }
  P1 := StrToPolynom(Polynom1.Text);
  P2 := StrToPolynom(Polynom2.Text);
  { ������������ }
  PR := SumPolynom(P1, P2);
  { �������������� PR � ������ }
  PolynomResult.Text := PolynomToStr(PR);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  CalculateButtonClick(Sender);
end;

end.
