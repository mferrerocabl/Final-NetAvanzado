<script setup lang="ts">

import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import { ref, onMounted } from 'vue';

const personList = ref([]);

const getPersonList = async ()=> {
  const response = await fetch('http://localhost:5000/persons')
  const data = await response.json()
  personList.value = data.personList;
}

onMounted(async () => { await getPersonList()})

</script>

<template>
  <main>
    <div class="grid">
     <div class="col-12">
     </div>
    </div>
    <div class="mb-3"></div>
    <div class="grid">
      <div class="col-12">
        <DataTable :value="personList">
            <Column field="id" header="Number"></Column>
            <Column field="firstName" header="Name"></Column>
            <Column field="lastName" header="Surname"></Column>
        </DataTable>
      </div>
    </div>
  </main>
</template>
