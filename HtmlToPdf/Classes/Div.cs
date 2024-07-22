public class Div : Generic
{
	private readonly Generic _elemento;

	public Div(Generic elemento)
	{
		_elemento = elemento;
	}

	public override string ToString()
	{
		return $"<div class='{base.ClassName}'>{_elemento.ToString()}</div>";
	}
}
