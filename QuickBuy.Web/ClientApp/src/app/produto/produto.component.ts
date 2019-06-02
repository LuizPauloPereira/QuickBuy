import {Component} from"@angular/core"

@Component({
  selector: "produto", //define nome da tag onde a classe será renderizada
  template:"<html><body>{{ obterNome() }}</body></html/>" //estrutura html onderenderiza o componente
})
export class ProdutoComponent { //PascalCase: NomeDasClasses
  //camelCase: variaveis, atributos e nomeDasFunções
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";
  }
}
