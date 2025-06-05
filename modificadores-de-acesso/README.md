# public
- Acesso Liberado: pode ser acessado de qualquer lugar (dentro e fora do assembly).

``` bash
public class Pessoa {
    public string Nome;
}
```

# private
- Acesso restrito à própria classe.
- Membros private não são visíveis fora da classe.

``` bash 
public class Pessoa {
    private int idade;
}
```

# protected 
- Acesso restrito à própria classe e às classes derivadas (herança).
- O protected permite acesso apenas dentro da própria classe e por classes que herdam dela.

``` bash 
public class Pessoa {
    protected void Falar() {}
}