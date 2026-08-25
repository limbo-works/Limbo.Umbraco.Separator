import { LitElement, html, css, repeat, when } from "@umbraco-cms/backoffice/external/lit";
import { UmbElementMixin } from "@umbraco-cms/backoffice/element-api";
import { UmbChangeEvent } from "@umbraco-cms/backoffice/event";
import { UMB_PROPERTY_CONTEXT, UmbPropertyContext } from "@umbraco-cms/backoffice/property";

export class LimboSeparatorElement extends UmbElementMixin(LitElement) {

    _label = "";
    _description = "";

    constructor() {
        super();
        this.consumeContext(UMB_PROPERTY_CONTEXT, (ctx) => {
            if (ctx.label) this.observe(ctx.label, (v) => (this._label = v ?? ""));
            if (ctx.description) this.observe(ctx.description, (v) => (this._description = v ?? ""));
        });
    }

    connectedCallback() {
        super.connectedCallback();
        const umbPropertyLayout = this.parentElement?.parentElement;
        if (umbPropertyLayout) {
            umbPropertyLayout.setAttribute("orientation", "vertical");
            const headerColumn = umbPropertyLayout.shadowRoot?.querySelector("#headerColumn");
            if (headerColumn) headerColumn.style.display = "none";
        }
    }

    render() {
        return html`
            <div class="limbo-separator">
                <div class="limbo-separator-title">${this._label}</div>
                ${when(this._description, () => html`
                    <div class="limbo-separator-description">${this._description}</div>
                `)}
            </div>
        `;
    }

    static styles = css`

        .limbo-separator {
            border-bottom: 2px solid #F4C1BC;
            margin: 0;
            padding: 0;
            margin-bottom: -21px;
            z-index: 2;
            position: relative;
        }

        .limbo-separator-title {
            font-size: 13px;
            text-transform: uppercase;
        }

        .limbo-separator-description {
            font-size: 11px;
            color: #333;
            margin-top: -5px;
        }

  `;

}

customElements.define("limbo-separator", LimboSeparatorElement);

export default LimboSeparatorElement;