(function(){const r=document.createElement("link").relList;if(r&&r.supports&&r.supports("modulepreload"))return;for(const e of document.querySelectorAll('link[rel="modulepreload"]'))c(e);new MutationObserver(e=>{for(const t of e)if(t.type==="childList")for(const s of t.addedNodes)s.tagName==="LINK"&&s.rel==="modulepreload"&&c(s)}).observe(document,{childList:!0,subtree:!0});function i(e){const t={};return e.integrity&&(t.integrity=e.integrity),e.referrerPolicy&&(t.referrerPolicy=e.referrerPolicy),e.crossOrigin==="use-credentials"?t.credentials="include":e.crossOrigin==="anonymous"?t.credentials="omit":t.credentials="same-origin",t}function c(e){if(e.ep)return;e.ep=!0;const t=i(e);fetch(e.href,t)}})();const n="data:image/svg+xml,%3csvg%20xmlns='http://www.w3.org/2000/svg'%20width='20'%20height='20'%20viewBox='0%200%2020%2020'%3e%3cpath%20d='M%2017.418%2014.908%20C%2017.69%2015.176%2018.127%2015.176%2018.397%2014.908%20C%2018.667%2014.64%2018.668%2014.207%2018.397%2013.939%20L%2010.489%206.109%20C%2010.219%205.841%209.782%205.841%209.51%206.109%20L%201.602%2013.939%20C%201.332%2014.207%201.332%2014.64%201.602%2014.908%20C%201.873%2015.176%202.311%2015.176%202.581%2014.908%20L%2010%207.767%20L%2017.418%2014.908%20Z'%3e%3c/path%3e%3c/svg%3e",a=o=>{const r=document.createElement("div");return r.innerHTML=typeof o=="string"?o:o.join(""),r.firstElementChild},u=()=>`
<div class="route route-get">
  <div class="route-header">
    <button class="route-summary">
      <div class="route-summary-method">GET</div>
      <span class="route-summary-path">/Users</span>
      <div class="route-summary-arrow"><img class="arrow" src=${n} /></div>
    </button>
  </div>
</div>`;(()=>{const o=document.querySelector("#app"),r=a(u());o&&r&&o.append(r)})();
