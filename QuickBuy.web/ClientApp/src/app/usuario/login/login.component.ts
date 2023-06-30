import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { ActivatedRoute, Router } from "@angular/router";


@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) { 
    this.usuario = new Usuario();
    this.returnUrl= this.activatedRouter.snapshot.queryParams['returnUrl']
  }

  entrar() {
    if (this.usuario.email == "tico@teste.com" && this.usuario.senha == "123123") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }
    
  }
  
}
