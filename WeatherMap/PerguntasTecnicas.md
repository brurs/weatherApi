1 - Usei cerca de 10h para o desenvolvimento.
	Poderia ter feito mais rapidamente porem utilizei esse projeto para estudar alguns t�picos.
	Ja havia desenvolvido em sistemas que utilizava CQRS e Mediatr, porem nunca criado e configurado um projeto nesse modelo do zero.

2 - Nenhum framework, porem utilizei algumas bibliotecas para auxiliar. 
	Mediatr para facilitar a gest�o de inje��es entre projetos no modelo de projeto que escolhi.
	Newtonsoft.Json para facilitar a interpreta��o de retorno da API externa.
	Moq e xunit para o projeto de testes.

3 - 
{
	"Pessoa": {
		"Nome": "Bruno Roger Stupp",
		"DataNascimento": "14/02/1996",
		"UF": "SC",
		"Cidade": "Blumenau",
		"Bairro":"Itoupava Seca",
		"Hobbies": [{
			"Nome": "Arquearia",
			"Descri��o": "Arquearia tradicional no Pakua"
		},
		{
			"Nome": "BDO",
			"Descri��o": "MMORPG Koerano horrivel"
		}],
		"Historico Escolar" : [
		{
			"Institui��o": "EBM Anita Garibaldi",
			"Status": "Completo",
			"Nivel": "Basico"
		},
		{
			"Institui��o": "Cedup Herman Hering",
			"Status": "Completo",
			"Nivel": "M�dio"
		},
		{
			"Institui��o": "Furb - Ciencia da Computa��o",
			"Status": "Incompleto",
			"Nivel": "Superior"
		},
		{
			"Institui��o": "Unicesumar - TADS",
			"Status": "Cursando",
			"Nivel": "Superior"
		}
		]
	}
}
	