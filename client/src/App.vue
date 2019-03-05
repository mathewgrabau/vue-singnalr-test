<template>
  <div id="app">
    <nav class="navbar navbar-expand-md navbar-dark bg-dark shadow">
      <a href="#/" class="navbar-brand">mini-SO</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#main-navbar" aria-controls="main-navbar" aria-expanded="false" aria-label="Toggle Navigation"><span class="navbar-toggler-icon"></span></button>

      <div class="collapse navbar-collapse" id="main-navbar">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a href="#/" class="nav-link">Home <span class="sr-only">(current)</span></a>
          </li>
        </ul>
        <form class="form-inline my-2 my-lg-0">
          <input type="text" class="form-control mr-sm-2" placeholder="Search" aria-label="Search">
          <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
        </form>
      </div>
    </nav>

    <main role="main" class="container mt-4">
      <router-view></router-view>
    </main>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>
