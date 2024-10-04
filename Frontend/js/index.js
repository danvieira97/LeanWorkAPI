async function obterCarrinho() {
    try {
        const token = localStorage.getItem("token");
        const response = await fetch('http://localhost:5160/api/Carrinho/1', {
            method: "GET",
            headers: {
                "Content-Type": "application/json",
            }
        });

        const responseJson = await response.json();
        if (response.ok) {
            await criarTabela(responseJson);
        } else {
            console.log("Erro ao obter o carrinho.");
        }
    } catch (error) {
        console.log("Erro na solicitação à API: " + error);
    }
}

obterCarrinho();

async function criarTabela(data) {
    console.log(data.itens);
    const table = document.getElementById("tabelaProdutos");
    let html = `
        <thead>
            <tr>
                <th>Produto</th>
                <th>Quantidade</th>
                <th>Preço</th>
                <th>Subtotal</th>
            </tr>
        </thead>
        <tbody>
    `

    data.itens.forEach(item => {
        html += `
            <tr>
                <td>${item.produto}</td>
                <td>${item.quantidade}</td>
                <td>${item.precoUnitario}</td>
                <td>${item.precoTotal}</td>
            </tr>
        `
    });

    html += `<
            tfoot>
                <tr>
                    <td class="text-end" colspan="3">Quantidade total: </td>
                    <td>${data.totalItens}</td>
                </tr>
                <tr>
                    <td class="text-end" colspan="3">Valor total: </td>
                    <td>${data.totalValor}</td>
                </tr>
            </>
        </table>`;

        table.innerHTML = html;
}

document.getElementById("adicionarItem").addEventListener("click", async () => {
    const produto = document.getElementById("produto").value;
    const quantidade = document.getElementById("quantidade").value;
    const precoUnitario = document.getElementById("precoUnitario").value;

    try {
        const token = localStorage.getItem("token");
        const response = await fetch('http://localhost:5160/api/Carrinho/1', {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({
                produto,
                quantidade,
                precoUnitario
            })
        });

        if (response.ok) {
            obterCarrinho();
        } else {
            console.log("Erro ao adicionar o item.");
        }
    } catch (error) {
        console.log("Erro na solicitação à API: " + error);
    }
});

const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
  const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
  toastTrigger.addEventListener('click', () => {
    toastBootstrap.show()
  })
}