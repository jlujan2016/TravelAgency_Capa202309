import{C as e,p as o,w as n,a as s,d as t,N as a}from"./p-d5b54d3b.js";const r="undefined"!=typeof Deno,p=!(r||"undefined"==typeof global||"function"!=typeof require||!global.process||"string"!=typeof __filename||global.origin&&"string"==typeof global.origin),c=(r&&Deno,p?process:r&&Deno,p?process:r&&Deno,()=>e&&e.supports&&e.supports("color","var(--c)")?s():__sc_import_chameleon("./p-0ad0b6e8.js").then(()=>(o.o=n.__cssshim)?(!1).i():0)),i=()=>{o.o=n.__cssshim;const e=Array.from(t.querySelectorAll("script")).find(e=>RegExp(`/${a}(\\.esm)?\\.js($|\\?|#)`).test(e.src)||e.getAttribute("data-stencil-namespace")===a),r=e["data-opts"]||{};return"onbeforeload"in e&&!history.scrollRestoration?{then(){}}:(r.resourcesUrl=new URL(".",new URL(e.getAttribute("data-resources-url")||e.src,n.location.href)).href,l(r.resourcesUrl,e),n.customElements?s(r):__sc_import_chameleon("./p-3d1015c2.js").then(()=>r))},l=(e,o)=>{const s="__sc_import_"+a.replace(/\s|-/g,"_");try{n[s]=Function("w","return import(w);//"+Math.random())}catch(r){const a=new Map;n[s]=r=>{const p=new URL(r,e).href;let c=a.get(p);if(!c){const e=t.createElement("script");e.type="module",e.crossOrigin=o.crossOrigin,e.src=URL.createObjectURL(new Blob([`import * as m from '${p}'; window.${s}.m = m;`],{type:"application/javascript"})),c=new Promise(o=>{e.onload=()=>{o(n[s].m),e.remove()}}),a.set(p,c),t.head.appendChild(e)}return c}}};export{c as a,i as p}