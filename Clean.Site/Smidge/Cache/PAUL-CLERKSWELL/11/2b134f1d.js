function labnolIframe(e){var t=document.createElement("iframe");t.setAttribute("src","https://www.youtube.com/embed/"+e.dataset.id+"?autoplay=1&rel=0"),t.setAttribute("frameborder","0"),t.setAttribute("allowfullscreen","1"),t.setAttribute("allow","accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"),e.parentNode.replaceChild(t,e)}
function initYouTubeVideos(){for(var e=document.getElementsByClassName("youtube-player"),t=0;t<e.length;t++){var i=e[t].dataset.id,n=document.createElement("div");n.setAttribute("data-id",i);var o=document.createElement("img");o.src="//i.ytimg.com/vi/ID/maxresdefault.jpg".replace("ID",i),o.alt="YouTube Video Thumbnail Image",n.appendChild(o);var s=document.createElement("div");s.setAttribute("class","play"),n.appendChild(s),n.onclick=function(){labnolIframe(this)},e[t].appendChild(n)}}
window.addEventListener('DOMContentLoaded',()=>{let scrollPos=0;const mainNav=document.getElementById('mainNav');const headerHeight=mainNav.clientHeight;window.addEventListener('scroll',function(){const currentTop=document.body.getBoundingClientRect().top* -1;if(currentTop<scrollPos){if(currentTop>0&&mainNav.classList.contains('is-fixed')){mainNav.classList.add('is-visible');}else{console.log(123);mainNav.classList.remove('is-visible','is-fixed');}}else{mainNav.classList.remove(['is-visible']);if(currentTop>headerHeight&&!mainNav.classList.contains('is-fixed')){mainNav.classList.add('is-fixed');}}
scrollPos=currentTop;});initYouTubeVideos();});